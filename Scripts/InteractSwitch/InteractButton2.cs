using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButton2 : MonoBehaviour
{
    public GameObject switchh;

    public void OnClick()
    {
        //if (SwitchhBall.green)
        //{
            
        //}

        if (SwitchhBall.green == false)
        {
            switchh.GetComponent<SwitchhBall>().ColorChange();
        }
    }
}
