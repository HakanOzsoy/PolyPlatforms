using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTP : MonoBehaviour
{
    public GameObject tper;
    public GameObject kamera;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            kamera.transform.position = tper.transform.position;
        }

    }
}
