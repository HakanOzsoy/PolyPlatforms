using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UFOanim : MonoBehaviour
{
    public GameObject TouchControls;
    public GameObject ufo;
    public GameObject player;
    public GameObject fakep;
    public GameObject darkscreen;
    public static bool intro = false;

    // Start is called before the first frame update
    void Start()
    {
        darkscreen.SetActive(false);
        ufo.SetActive(false);
        fakep.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            TouchControls.SetActive(false);
            PressedRight.Rispressed = false;
            PressedLeft.Lispressed = false;
            Invoke("Ufo", 1);         
        }
    }

    void Ufo()
    {
        ufo.SetActive(true);
        Invoke("Elevate", 2);
    }

    void Elevate()
    {
        player.SetActive(false);
        fakep.SetActive(true);
        Invoke("Dark", 3);
    }

    void Dark()
    {
        darkscreen.SetActive(true);
        Invoke("NextLevel", 2);
    }

    void NextLevel()
    {
        intro = true;
        SceneManager.LoadScene("Level1");
    }
}
