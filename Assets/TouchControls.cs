//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/TouchControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @TouchControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchControls"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""bbbc02c0-a3aa-4c3d-8173-ceda88c9f3d7"",
            ""actions"": [
                {
                    ""name"": ""PrimaryFinger"",
                    ""type"": ""Value"",
                    ""id"": ""e2cd0dfe-ad37-44c5-835f-92074dd34f55"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryFinger"",
                    ""type"": ""Value"",
                    ""id"": ""0b97894a-643f-4cf6-9b45-f834c01ea84d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryTouchContact"",
                    ""type"": ""Button"",
                    ""id"": ""0c1138a3-e797-456d-acd5-73b73befdf0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TestZoom"",
                    ""type"": ""Button"",
                    ""id"": ""99f5167a-5996-42d5-873d-12a1dfde2030"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1c1a00c8-ac3b-41fd-bdde-67e961089542"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFinger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d7d0707-3872-47b9-96ca-a97ba54bc09f"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryFinger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5d3b452-c3e4-43ec-8a48-5c7af51c628a"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouchContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9d2616d-27cf-4099-90de-842d1ee2836f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TestZoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_PrimaryFinger = m_Touch.FindAction("PrimaryFinger", throwIfNotFound: true);
        m_Touch_SecondaryFinger = m_Touch.FindAction("SecondaryFinger", throwIfNotFound: true);
        m_Touch_SecondaryTouchContact = m_Touch.FindAction("SecondaryTouchContact", throwIfNotFound: true);
        m_Touch_TestZoom = m_Touch.FindAction("TestZoom", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_PrimaryFinger;
    private readonly InputAction m_Touch_SecondaryFinger;
    private readonly InputAction m_Touch_SecondaryTouchContact;
    private readonly InputAction m_Touch_TestZoom;
    public struct TouchActions
    {
        private @TouchControls m_Wrapper;
        public TouchActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryFinger => m_Wrapper.m_Touch_PrimaryFinger;
        public InputAction @SecondaryFinger => m_Wrapper.m_Touch_SecondaryFinger;
        public InputAction @SecondaryTouchContact => m_Wrapper.m_Touch_SecondaryTouchContact;
        public InputAction @TestZoom => m_Wrapper.m_Touch_TestZoom;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @PrimaryFinger.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFinger;
                @PrimaryFinger.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFinger;
                @PrimaryFinger.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFinger;
                @SecondaryFinger.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFinger;
                @SecondaryFinger.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFinger;
                @SecondaryFinger.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFinger;
                @SecondaryTouchContact.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @SecondaryTouchContact.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @SecondaryTouchContact.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @TestZoom.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTestZoom;
                @TestZoom.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTestZoom;
                @TestZoom.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTestZoom;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryFinger.started += instance.OnPrimaryFinger;
                @PrimaryFinger.performed += instance.OnPrimaryFinger;
                @PrimaryFinger.canceled += instance.OnPrimaryFinger;
                @SecondaryFinger.started += instance.OnSecondaryFinger;
                @SecondaryFinger.performed += instance.OnSecondaryFinger;
                @SecondaryFinger.canceled += instance.OnSecondaryFinger;
                @SecondaryTouchContact.started += instance.OnSecondaryTouchContact;
                @SecondaryTouchContact.performed += instance.OnSecondaryTouchContact;
                @SecondaryTouchContact.canceled += instance.OnSecondaryTouchContact;
                @TestZoom.started += instance.OnTestZoom;
                @TestZoom.performed += instance.OnTestZoom;
                @TestZoom.canceled += instance.OnTestZoom;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    public interface ITouchActions
    {
        void OnPrimaryFinger(InputAction.CallbackContext context);
        void OnSecondaryFinger(InputAction.CallbackContext context);
        void OnSecondaryTouchContact(InputAction.CallbackContext context);
        void OnTestZoom(InputAction.CallbackContext context);
    }
}
