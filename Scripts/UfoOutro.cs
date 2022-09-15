using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoOutro : MonoBehaviour
{
    public GameObject ufoL;
    public GameObject fakec;
    public GameObject realc;

    // Start is called before the first frame update
    void Start()
    {
        realc.SetActive(false);
        fakec.SetActive(false);
        ufoL.SetActive(false);
        Invoke("UfoLight", 2);
    }

    void UfoLight()
    {
        ufoL.SetActive(true);
        Invoke("GoDown", 1);
    }

    void GoDown()
    {
        fakec.SetActive(true);
        Invoke("LightDelete", 3);
    }

    void LightDelete()
    {
        Destroy(ufoL);
        Destroy(fakec);
        realc.SetActive(true);
    }
}
