using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLevel1 : MonoBehaviour
{
    public void OnClick()
    {
        if(UFOanim.intro == false)
        {
            SceneManager.LoadScene("Intro");
        }

        if(UFOanim.intro)
        {
            Time.timeScale = 1;
            Coin.LevelCoins = 0;
            SceneManager.LoadScene("Level1");
        }
    }
}
