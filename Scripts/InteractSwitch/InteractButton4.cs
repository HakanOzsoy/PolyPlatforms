using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButton4 : MonoBehaviour
{
    public GameObject switchh;

    public void OnClick()
    {
        //if (SwitchhKey.green)
        //{

        //}

        if (SwitchhKey.green == false)
        {
            switchh.GetComponent<SwitchhKey>().ColorChange();
        }
    }
}
