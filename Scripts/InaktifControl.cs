using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InaktifControl : MonoBehaviour
{
    public GameObject kapak;
    public GameObject dark;

    // Start is called before the first frame update
    void Start()
    {
        kapak.SetActive(false);
        dark.SetActive(false);
    }
}
