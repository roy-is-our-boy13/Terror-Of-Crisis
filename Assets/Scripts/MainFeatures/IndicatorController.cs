using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class IndicatorController : MonoBehaviour
{
    [SerializeField] Button indicator;
    [SerializeField] Canvas canvas;

    public Action<bool> IndicatorWasClicked;
    bool isGrabbed;

    public void HandleIndicatorClicked()
    {
        isGrabbed = !isGrabbed;
        IndicatorWasClicked?.Invoke(isGrabbed); // Use null conditional operator to safely invoke the delegate
    }

    public void OnEnable()
    {
        indicator.onClick.AddListener(HandleIndicatorClicked);
    }

    public void OnDisable()
    {
        indicator.onClick.RemoveListener(HandleIndicatorClicked);
    }

    public void Update()
    {
         if(isGrabbed)
        {
            Vector2 pos;

            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out pos);
            transform.position = canvas.transform.TransformPoint(pos);

        }
    }
}
