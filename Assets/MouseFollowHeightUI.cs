using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollowHeightUI : MonoBehaviour
{
    private Vector2 _mousePosition;
    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

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
        var rectTransformPosition = _rectTransform.position;
        rectTransformPosition.y = _mousePosition.y;
        _rectTransform.position = rectTransformPosition;
    }
}
