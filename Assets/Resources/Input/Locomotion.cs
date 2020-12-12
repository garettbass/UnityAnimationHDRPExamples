// GENERATED AUTOMATICALLY FROM 'Assets/Resources/Input/Locomotion.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Locomotion: IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Locomotion()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Locomotion"",
    ""maps"": [
        {
            ""name"": ""Crawling"",
            ""id"": ""ef7861e3-c0b5-4aed-8770-d91c6ca1a455"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""27c64ad2-8586-4293-8f84-b5f6036a91a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""64bc07c2-383b-4343-9f0f-22ea3cee4409"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Standing"",
            ""id"": ""1fbadec6-66e2-46f2-aaa2-7d564556c969"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""33611046-2b7a-4b15-bd6d-b1dca0b40bb2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""bb274f5e-9460-4b87-9149-83d6b9dd9196"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dc83a4f6-8f8d-47eb-9102-134b8a47ec3e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d433cec8-2c58-4cb4-ae98-7dd821a6fbcc"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Climbing"",
            ""id"": ""610b49df-4f74-4862-9ab0-063a52bf2c63"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""00d5314f-64dc-4783-be2a-3474a29692d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1eb9d611-7c51-44e4-97cd-9076a24dde72"",
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
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        }
    ]
}");
        // Crawling
        m_Crawling = asset.FindActionMap("Crawling", throwIfNotFound: true);
        m_Crawling_Newaction = m_Crawling.FindAction("New action", throwIfNotFound: true);
        // Standing
        m_Standing = asset.FindActionMap("Standing", throwIfNotFound: true);
        m_Standing_Move = m_Standing.FindAction("Move", throwIfNotFound: true);
        m_Standing_Look = m_Standing.FindAction("Look", throwIfNotFound: true);
        // Climbing
        m_Climbing = asset.FindActionMap("Climbing", throwIfNotFound: true);
        m_Climbing_Newaction = m_Climbing.FindAction("New action", throwIfNotFound: true);
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

    // Crawling
    private readonly InputActionMap m_Crawling;
    private ICrawlingActions m_CrawlingActionsCallbackInterface;
    private readonly InputAction m_Crawling_Newaction;
    public struct CrawlingActions
    {
        private @Locomotion m_Wrapper;
        public CrawlingActions(@Locomotion wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Crawling_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Crawling; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CrawlingActions set) { return set.Get(); }
        public void SetCallbacks(ICrawlingActions instance)
        {
            if (m_Wrapper.m_CrawlingActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_CrawlingActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_CrawlingActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_CrawlingActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_CrawlingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public CrawlingActions @Crawling => new CrawlingActions(this);

    // Standing
    private readonly InputActionMap m_Standing;
    private IStandingActions m_StandingActionsCallbackInterface;
    private readonly InputAction m_Standing_Move;
    private readonly InputAction m_Standing_Look;
    public struct StandingActions
    {
        private @Locomotion m_Wrapper;
        public StandingActions(@Locomotion wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Standing_Move;
        public InputAction @Look => m_Wrapper.m_Standing_Look;
        public InputActionMap Get() { return m_Wrapper.m_Standing; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StandingActions set) { return set.Get(); }
        public void SetCallbacks(IStandingActions instance)
        {
            if (m_Wrapper.m_StandingActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_StandingActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_StandingActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_StandingActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_StandingActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_StandingActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_StandingActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_StandingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public StandingActions @Standing => new StandingActions(this);

    // Climbing
    private readonly InputActionMap m_Climbing;
    private IClimbingActions m_ClimbingActionsCallbackInterface;
    private readonly InputAction m_Climbing_Newaction;
    public struct ClimbingActions
    {
        private @Locomotion m_Wrapper;
        public ClimbingActions(@Locomotion wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Climbing_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Climbing; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ClimbingActions set) { return set.Get(); }
        public void SetCallbacks(IClimbingActions instance)
        {
            if (m_Wrapper.m_ClimbingActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_ClimbingActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_ClimbingActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_ClimbingActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_ClimbingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public ClimbingActions @Climbing => new ClimbingActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface ICrawlingActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IStandingActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IClimbingActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
