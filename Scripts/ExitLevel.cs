using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    public void OnClick()
    {
        Time.timeScale = 1;
        Coin.LevelCoins = 0;
        SceneManager.LoadScene("LevelSelection");
    }
}
