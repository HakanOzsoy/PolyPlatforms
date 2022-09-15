using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PressedRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool Rispressed = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        Rispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Rispressed = false;
    }
}
