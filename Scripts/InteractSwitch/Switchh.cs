using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchh : MonoBehaviour
{

    public GameObject inButton;
    public GameObject platform;
    public static bool green = false;

    SpriteRenderer Srenderer;

    // Start is called before the first frame update
    void Start()
    {
        inButton.SetActive(false);
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

    public void ColorChange1()
    {
        Srenderer.color = new Color32(254, 56, 38, 255);
        Invoke("boolchange1", 0.3f);
        platform.GetComponent<Animator>().SetFloat("Aspeed", 0);
    }

    public void ColorChange2()
    {
        Srenderer.color = new Color32(0, 202, 7, 255);
        Invoke("boolchange2", 0.3f);
        platform.GetComponent<Animator>().SetFloat("Aspeed", 1);
    }

    public void boolchange1()
    {
        green = false;
    }

    public void boolchange2()
    {
        green = true;
    }
}
