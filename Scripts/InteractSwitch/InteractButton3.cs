using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButton3 : MonoBehaviour
{
    public GameObject switchh;

    public void OnClick()
    {
        //if (SwitchhLaser.green)
        //{
        //    switchh.GetComponent<SwitchhLaser>().ColorChange1();
        //}

        if (SwitchhLaser.green == false)
        {
            switchh.GetComponent<SwitchhLaser>().ColorChange2();
        }
    }
}
