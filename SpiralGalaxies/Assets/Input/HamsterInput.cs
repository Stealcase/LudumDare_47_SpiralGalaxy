// GENERATED AUTOMATICALLY FROM 'Assets/Input/HamsterInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @HamsterInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @HamsterInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""HamsterInput"",
    ""maps"": [
        {
            ""name"": ""HamsterActions"",
            ""id"": ""ac560763-f17f-41af-bd15-724733aeeac6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""38c02d6b-e352-46d5-b766-16ac7df0f958"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""17b1aad9-1984-4c80-88d9-82819c2bb2ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""ab31812c-2ec2-4010-95ac-d98ea0fdd678"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""60c1fac7-40f8-4fab-b719-b693bd866bdd"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ec9e6d26-472a-472f-8bc8-4ca7ab94547f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cd7d17ab-3f53-4221-933c-a8d25461d87f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f4452baf-bdde-448e-94e1-d61b8dd3a24c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""98f3759a-b92a-41b6-a94a-bf48d8825fe3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""42f17871-59ef-4832-b010-a41b2445d1db"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9aa089a4-b337-4217-9bfd-586565b7028f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""MouseCam"",
                    ""id"": ""2c0dbe87-88a5-431a-bada-11083698d197"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2fefb49d-c3c2-44e2-b649-89b31fb28355"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c8e372db-fa9b-4986-afe8-cb4ff74f5f40"",
                    ""path"": ""<Mouse>/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // HamsterActions
        m_HamsterActions = asset.FindActionMap("HamsterActions", throwIfNotFound: true);
        m_HamsterActions_Move = m_HamsterActions.FindAction("Move", throwIfNotFound: true);
        m_HamsterActions_Jump = m_HamsterActions.FindAction("Jump", throwIfNotFound: true);
        m_HamsterActions_Camera = m_HamsterActions.FindAction("Camera", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // HamsterActions
    private readonly InputActionMap m_HamsterActions;
    private IHamsterActionsActions m_HamsterActionsActionsCallbackInterface;
    private readonly InputAction m_HamsterActions_Move;
    private readonly InputAction m_HamsterActions_Jump;
    private readonly InputAction m_HamsterActions_Camera;
    public struct HamsterActionsActions
    {
        private @HamsterInput m_Wrapper;
        public HamsterActionsActions(@HamsterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_HamsterActions_Move;
        public InputAction @Jump => m_Wrapper.m_HamsterActions_Jump;
        public InputAction @Camera => m_Wrapper.m_HamsterActions_Camera;
        public InputActionMap Get() { return m_Wrapper.m_HamsterActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HamsterActionsActions set) { return set.Get(); }
        public void SetCallbacks(IHamsterActionsActions instance)
        {
            if (m_Wrapper.m_HamsterActionsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_HamsterActionsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_HamsterActionsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_HamsterActionsActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_HamsterActionsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_HamsterActionsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_HamsterActionsActionsCallbackInterface.OnJump;
                @Camera.started -= m_Wrapper.m_HamsterActionsActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_HamsterActionsActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_HamsterActionsActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_HamsterActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public HamsterActionsActions @HamsterActions => new HamsterActionsActions(this);
    public interface IHamsterActionsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
    }
}
