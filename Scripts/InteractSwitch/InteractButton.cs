using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButton : MonoBehaviour
{
    public GameObject switchh;

    public void OnClick()
    {
        if (Switchh.green)
        {
            switchh.GetComponent<Switchh>().ColorChange1();
        }

        if (Switchh.green == false)
        {
            switchh.GetComponent<Switchh>().ColorChange2();
        }
    }
}
