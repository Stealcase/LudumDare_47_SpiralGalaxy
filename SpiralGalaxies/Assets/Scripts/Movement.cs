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
                rb.drag = 1;
                Vector2 direction =  context.ReadValue<Vector2>()*speed;

                Vector3 dir3D = new Vector3(direction.x, 0, direction.y);


                if (direction.magnitude < 0.3)
                {
                    forceDir = context.ReadValue<Vector2>();
                    return;
                }
                forceDir = dir3D;
            }
            if (context.canceled)
            {
                rb.drag = 500;
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
            rb.AddForce(forceDir);
        }
  

    }
}
