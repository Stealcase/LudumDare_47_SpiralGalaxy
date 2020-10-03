using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

namespace Assets.Scripts
{
    class Movement : MonoBehaviour, HamsterInput.IHamsterActionsActions
    {
        public HamsterInput hamsterInputActions;
        public Rigidbody rb;

        private InputAction moveAction;
        private InputAction jumpAction;
        private Vector3 forceDir;
        [Range(0,30)]public float speed;
        [Range(0, 30)] public float maxVelocity;

        [Tooltip("Force used to stop the object when no movement input is given.")]
        [SerializeField][Range(0,50)] private float stopFriction = 50;
        [Tooltip("Force used to counteract deviations in the velocity from the input direction, makes turns sharper.")]
        [SerializeField][Range(0,50)] private float turnFriction = 20;
        [Tooltip("Force used to help in turning the velocity around for 180 turns and the like.")]
        [SerializeField] [Range(0, 50)] private float turnAroundFriction = 20;

        public bool ApplyFriction { get; private set; } = true;

        public void Awake()
        {
            hamsterInputActions = new HamsterInput();
            hamsterInputActions.HamsterActions.SetCallbacks(this);
        }
        public void OnEnable()
        {
            hamsterInputActions.Enable();

        }
        public void OnDisable()
        {
            hamsterInputActions.Disable();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                ApplyFriction = false;
                Vector2 direction =  context.ReadValue<Vector2>();

                Vector3 dir3D = new Vector3(direction.x, 0, direction.y);

                forceDir = dir3D;
            }
            if (context.canceled)
            {
                ApplyFriction = true;
            }
          
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                rb.AddForce(Vector3.up * 2, ForceMode.Impulse);
            }
        }
        public void FixedUpdate()
        {
            if(rb.velocity.sqrMagnitude < maxVelocity)
            {
                rb.AddForce(forceDir * speed);
            }
  
            //Logic for slowing down when no force is applied
                if (!ApplyFriction)
                    return;

                if (forceDir == Vector3.zero)
                {
                    rb.AddForce(-rb.velocity * stopFriction, ForceMode.Force);
                }
                else
                {
                    Vector3 headingVelocity = Vector3.Project(rb.velocity, forceDir);
                    if (Vector2.Angle(forceDir, headingVelocity) <= 1)
                    {
                        rb.AddForce(-(rb.velocity - headingVelocity) * turnFriction, ForceMode.Force);
                    }
                    else
                    {
                        rb.AddForce(-rb.velocity * turnAroundFriction, ForceMode.Force);
                    }
                }
            }
        }
    }

