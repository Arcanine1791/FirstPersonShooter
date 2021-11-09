// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Abinav"",
            ""id"": ""8117a10d-32ec-4de1-ad16-f010a4e876ed"",
            ""actions"": [
                {
                    ""name"": ""kadulu"",
                    ""type"": ""Button"",
                    ""id"": ""a0369bfe-41df-4379-9969-dfa67b3c3bd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""744f31b5-cb5a-4fe7-8214-7d934c81f804"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""4da48dcc-a4ac-4569-9f79-eb8831ec6df7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3954cefb-f2f7-424f-9846-3d8704a46284"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e00e79f4-7aa1-4dd2-ac18-980daa0f778f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""kadulu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cc8a3195-d06d-4a19-a98a-3f5d08bdc9c5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d9cc2a2e-e354-413a-ab81-5ede31906e8a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""867f279d-c78f-4dbc-acb4-223df01321c3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""58b68f85-ff0a-4033-82a3-6275860599c5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2aaa3c9d-09f1-42f4-8b22-bb00279578a5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""kadulu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7ae64cc4-c519-4b8c-9360-161131bfae6f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""268cfac3-7f99-449e-8207-01af2e4bf459"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fffa80fe-9e98-4d4d-a4a8-5f81ae8f8d40"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f5515c83-6d07-4028-9871-305af9affad2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a927e783-0344-496a-87dd-2134d8024f33"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""kadulu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""87d867c7-d1ab-47bb-95d9-fbf0e3b6ec04"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""JoyStick"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5a2034ac-9d82-47a1-a9a9-562bb087c6c5"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""JoyStick"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""862102a5-a37d-432f-87fb-965434c016ee"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""JoyStick"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""edfad1a6-f253-4047-b57e-e5b0a09a2508"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""JoyStick"",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""84c3e76c-34a9-407a-ae3a-2a8a7013a87c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""kadulu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b07b80a2-bc2e-4adc-97a3-199afd98f8d2"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""JoyStick"",
            ""bindingGroup"": ""JoyStick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Abinav
        m_Abinav = asset.FindActionMap("Abinav", throwIfNotFound: true);
        m_Abinav_kadulu = m_Abinav.FindAction("kadulu", throwIfNotFound: true);
        m_Abinav_jump = m_Abinav.FindAction("jump", throwIfNotFound: true);
        m_Abinav_Newaction = m_Abinav.FindAction("New action", throwIfNotFound: true);
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

    // Abinav
    private readonly InputActionMap m_Abinav;
    private IAbinavActions m_AbinavActionsCallbackInterface;
    private readonly InputAction m_Abinav_kadulu;
    private readonly InputAction m_Abinav_jump;
    private readonly InputAction m_Abinav_Newaction;
    public struct AbinavActions
    {
        private @PlayerInputActions m_Wrapper;
        public AbinavActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @kadulu => m_Wrapper.m_Abinav_kadulu;
        public InputAction @jump => m_Wrapper.m_Abinav_jump;
        public InputAction @Newaction => m_Wrapper.m_Abinav_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Abinav; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AbinavActions set) { return set.Get(); }
        public void SetCallbacks(IAbinavActions instance)
        {
            if (m_Wrapper.m_AbinavActionsCallbackInterface != null)
            {
                @kadulu.started -= m_Wrapper.m_AbinavActionsCallbackInterface.OnKadulu;
                @kadulu.performed -= m_Wrapper.m_AbinavActionsCallbackInterface.OnKadulu;
                @kadulu.canceled -= m_Wrapper.m_AbinavActionsCallbackInterface.OnKadulu;
                @jump.started -= m_Wrapper.m_AbinavActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_AbinavActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_AbinavActionsCallbackInterface.OnJump;
                @Newaction.started -= m_Wrapper.m_AbinavActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_AbinavActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_AbinavActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_AbinavActionsCallbackInterface = instance;
            if (instance != null)
            {
                @kadulu.started += instance.OnKadulu;
                @kadulu.performed += instance.OnKadulu;
                @kadulu.canceled += instance.OnKadulu;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public AbinavActions @Abinav => new AbinavActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_JoyStickSchemeIndex = -1;
    public InputControlScheme JoyStickScheme
    {
        get
        {
            if (m_JoyStickSchemeIndex == -1) m_JoyStickSchemeIndex = asset.FindControlSchemeIndex("JoyStick");
            return asset.controlSchemes[m_JoyStickSchemeIndex];
        }
    }
    public interface IAbinavActions
    {
        void OnKadulu(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
    }
}
