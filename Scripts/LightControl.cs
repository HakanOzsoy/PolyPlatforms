using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public GameObject glolight;
    public static bool turnlight = false;
    // Start is called before the first frame update

    void Start()
    {
        turnlight = false;
        LightShow();
    }

    // Update is called once per frame
    void Update()
    {
        if(turnlight)
        {
            glolight.SetActive(true);
        }
    }

    public void LightShow()
    {
        glolight.SetActive(true);
        if(turnlight == false)
        {
            Invoke("LightOff", 1f);
        }     
    }

    void LightOff()
    {
        glolight.SetActive(false);
        Invoke("LightShow", 1.5f);
    }
}
