using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsButton : MonoBehaviour
{
    public GameObject onText;
    public GameObject offText;
    public static bool sounds = true;
    // Start is called before the first frame update

    void Start()
    {
        offText.SetActive(false);
        onText.SetActive(false);

        if(sounds)
        {
            offText.SetActive(false);
            onText.SetActive(true);
        }

        if (sounds == false)
        {
            offText.SetActive(true);
            onText.SetActive(false);
        }
    }

    public void OnClick()
    {
        if(sounds)
        {
            sounds = false;
            offText.SetActive(true);
            onText.SetActive(false);
            AudioListener.volume = 0f;
        }
        else if(sounds == false)
        {
            sounds = true;
            offText.SetActive(false);
            onText.SetActive(true);
            AudioListener.volume = 1f;
        }
    }
}
