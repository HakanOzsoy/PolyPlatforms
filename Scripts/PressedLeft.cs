using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PressedLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool Lispressed = false;
    // Start is called before the first frame update

    public void OnPointerDown(PointerEventData eventData)
    {
        Lispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Lispressed = false;
    }
}
