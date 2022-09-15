using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminShortcut : MonoBehaviour
{
    public GameObject konum;
    public GameObject karakter;

    Vector3 pos1;

    // Start is called before the first frame update
    void Start()
    {
        pos1 = konum.transform.position;
    }

    public void OnMouseDown()
    {
        karakter.transform.position = pos1;
    }
}
