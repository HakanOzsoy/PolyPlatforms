using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterKeyDoor : MonoBehaviour
{
    public GameObject inButton;

    // Start is called before the first frame update
    void Start()
    {
        inButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            inButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            inButton.SetActive(false);
        }
    }
}
