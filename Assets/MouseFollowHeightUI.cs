using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollowHeightUI : MonoBehaviour
{
    private Vector2 _mousePosition;

    private void OnEnable()
    {
        InputManager.Instance.MousePositionChangedEvent += OnMousePositionChanged;
    }

    private void OnDisable()
    {
        InputManager.Instance.MousePositionChangedEvent += OnMousePositionChanged;
    }

    private void OnMousePositionChanged(Vector2 obj)
    {
        _mousePosition = obj;
    }
    
    void Update()
    {
        
    }
}
