using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractLights : MonoBehaviour
{
    public GameObject switchh;

    public void OnClick()
    {
        //if (SwitchhLights.green)
        //{

        //}

        if (SwitchhLights.green == false)
        {
            switchh.GetComponent<SwitchhLights>().ColorChange();
        }
    }
}
