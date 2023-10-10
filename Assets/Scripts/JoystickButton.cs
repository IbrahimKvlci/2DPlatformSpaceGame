using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [HideInInspector]
    public bool _clickedButton;



    public void OnPointerDown(PointerEventData eventData)
    {
        _clickedButton = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _clickedButton = false;
    }
}
