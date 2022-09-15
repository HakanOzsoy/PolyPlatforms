using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Gate1;
    public int ballin = 0;

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            ballin = 1;
            Gate1.GetComponent<OpenDoorOnTouch>().OpenDoor();
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Gate1.GetComponent<OpenDoorOnTouch>().OpenDoor();
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            if(ballin == 0)
            {
                Gate1.GetComponent<OpenDoorOnTouch>().CloseDoor();
            }          
        }
        if (col.gameObject.CompareTag("Ball"))
        {
                Gate1.GetComponent<OpenDoorOnTouch>().CloseDoor();
                ballin = 0;
        }
    }
}
