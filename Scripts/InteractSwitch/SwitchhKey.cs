using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchhKey : MonoBehaviour
{
    public GameObject inButton;
    public GameObject key;
    public static bool green = false;

    SpriteRenderer Srenderer;

    // Start is called before the first frame update
    void Start()
    {
        inButton.SetActive(false);
        key.SetActive(false);
        Srenderer = GetComponent<SpriteRenderer>();
        green = false;
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

    public void ColorChange()
    {
        Srenderer.color = new Color32(0, 202, 7, 255);
        Invoke("boolchange", 0.3f);
        key.SetActive(true);
    }

    public void boolchange()
    {
        green = true;
    }
}
