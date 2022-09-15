using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel3 : MonoBehaviour
{
    public int StarCheck;
    public GameObject LevelScreen;
    public GameObject TouchControls;
    public GameObject menuButton;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;

    // Start is called before the first frame update
    void Start()
    {
        LevelScreen.SetActive(false);
        Star1.SetActive(false);
        Star2.SetActive(false);
        Star3.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            menuButton.SetActive(false);
            TouchControls.SetActive(false);
            PressedRight.Rispressed = false;
            PressedLeft.Lispressed = false;
            LevelScreen.SetActive(true);

            if (Coin.LevelCoins > 0)
            {
                StarCheck = 1;
                Invoke("LevelStar1", 0.5f);
            }

            if (Coin.LevelCoins > 1)
            {
                StarCheck = 2;
                Invoke("LevelStar2", 1f);
            }

            if (Coin.LevelCoins > 3)
            {
                StarCheck = 3;
                Invoke("LevelStar3", 1.5f);
            }

            LevelStats.level3 = true;

            if (LevelStats.level3Star < StarCheck)
            {
                LevelStats.level3Star = StarCheck;
            }
        }
    }

    void LevelStar1()
    {
        Star1.SetActive(true);
    }

    void LevelStar2()
    {
        Star2.SetActive(true);
    }

    void LevelStar3()
    {
        Star3.SetActive(true);
    }
}
