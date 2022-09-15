using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        //character.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, CharacterController.JumpSpeed), ForceMode2D.Impulse);
        CharacterController.JumpFromButton();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
    }
}
