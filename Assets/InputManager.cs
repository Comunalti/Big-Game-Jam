using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : Singleton<InputManager>, GameInput.IMouseActions
{
    private GameInput _gameInput;
    private void Awake()
    {
        _gameInput = new GameInput();
        _gameInput.Mouse.SetCallbacks(this);
    }

    private void OnEnable()
    {
        _gameInput.Mouse.Enable();
    }

    private void OnDisable()
    {
        _gameInput.Mouse.Disable();
    }

    public event Action<Vector2> MousePositionChangedEvent;
    public void OnMove(InputAction.CallbackContext context)
    {
        
        var readValue = context.ReadValue<Vector2>();
        if (context.performed || context.canceled)
        {
            MousePositionChangedEvent?.Invoke(readValue);
        }
    }
}

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instace;

    public static T Instance
    {
        get
        {
            if (_instace is null)
            {
                _instace = FindObjectOfType<T>();
            }

            if (_instace is null)
            {
                Debug.LogError($"no {typeof(T).Name} found");
            }

            return _instace;
        }
    }
}
