﻿using Cinemachine;
using FMODUnity;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

namespace Assets.Scripts
{
    public class Movement : MonoBehaviour, HamsterInput.IHamsterActionsActions
    {
        public HamsterInput hamsterInputActions;
        public Rigidbody rb;

        CollisionManager collisions;
        private Vector2 direction;

        public StudioEventEmitter jumpEmitter;

        public float turnSmoothTime = 0.1f;
        public Transform hamstar;
        public Transform cam;
        private float turnSmoothVelocity;

        private bool IsGrounded
        {
            get { return collisions.isGrounded; }
        }
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
            collisions = GetComponentInChildren<CollisionManager>();
            hamsterInputActions = new HamsterInput();
            hamsterInputActions.HamsterActions.SetCallbacks(this);
        }
        public void OnEnable()
        {
            GameManager.hamster = this;
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
                direction =  context.ReadValue<Vector2>();
                rb.angularDrag = 0;
            }
            if (context.canceled)
            {
                direction = Vector2.zero;
                ApplyFriction = true;
                rb.angularDrag = 300;
            }
          
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            if (context.performed && IsGrounded)
            {
                if (!jumpEmitter.IsPlaying())
                {
                    jumpEmitter.Play();
                }

                rb.AddForce(Vector3.up * 2, ForceMode.Impulse);
            }
        }
        public void FixedUpdate()
        {
            Vector3 headingVelocity = Vector3.Project(rb.velocity, direction);



            //Create a Target Angle By getting the Degrees of The direction, then adding the camera 
            float hamsterY = hamstar.eulerAngles.y;
                float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + hamsterY;
                float angle = Mathf.SmoothDampAngle(hamsterY, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            hamstar.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0, targetAngle, 0f) * Vector3.forward;
            if (rb.velocity.sqrMagnitude < maxVelocity)
            {
            
                rb.AddForce(moveDir * speed);
                
            }


            //Logic for slowing down when no force is applied
           if (!ApplyFriction)
                    return;

                if (direction == Vector2.zero && IsGrounded)
                {
                rb.AddForce(-(rb.velocity - headingVelocity) * stopFriction, ForceMode.Force);
            }
                else
                {
                    if (Vector3.Angle(direction, headingVelocity ) <= 1 && IsGrounded)
                    {
                        rb.AddForce(-(rb.velocity - headingVelocity) * turnFriction, ForceMode.Force);
                    }
                    else if(IsGrounded)
                    {
                        rb.AddForce(-rb.velocity * turnAroundFriction, ForceMode.Force);
                    }
                } 
            }

        public void OnCamera(InputAction.CallbackContext context)
        {

        }
    }
    }

