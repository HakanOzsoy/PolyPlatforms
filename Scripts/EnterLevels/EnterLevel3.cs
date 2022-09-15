using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLevel3 : MonoBehaviour
{
    public void OnMouseDown()
    {
        Time.timeScale = 1;
        Coin.LevelCoins = 0;
        SceneManager.LoadScene("Level3");
    }
}
