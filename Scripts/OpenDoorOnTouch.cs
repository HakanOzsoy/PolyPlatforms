using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorOnTouch : MonoBehaviour
{
    static Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    //private void OnCollisionEnter2D(Collision2D coll)
    //{
    //    if (coll.gameObject.CompareTag("Player"))
    //    {
    //        anim.enabled = true;
    //        OpenDoor();
    //    }
    //}

    public void OpenDoor()
    {
        //anim.SetFloat("ASpeed", 1);
        anim.Play("GateOpen");
    }

    public void CloseDoor()
    {
        //anim.SetFloat("Speed", -1);
        anim.Play("GateClose");
    }
}
