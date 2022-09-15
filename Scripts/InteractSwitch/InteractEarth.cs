using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractEarth : MonoBehaviour
{
    public GameObject kapak;
    public GameObject touchCont;
    public GameObject dark;

    // Start is called before the first frame update
    void Start()
    {
        kapak.SetActive(false);
        dark.SetActive(false);
    }

    public void OnClick()
    {
        touchCont.SetActive(false);
        PressedRight.Rispressed = false;
        PressedLeft.Lispressed = false;
        kapak.SetActive(true);
        Invoke("DarkScreen", 2);
    }

    void DarkScreen()
    {
        dark.SetActive(true);
        Invoke("Outro", 2.5f);
    }

    void Outro()
    {
        SceneManager.LoadScene("Outro");
    }
}
