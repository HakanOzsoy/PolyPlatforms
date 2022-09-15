using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetStats : MonoBehaviour
{
    public void OnClick()
    {
        LevelStats.level1 = false;
        LevelStats.level2 = false;
        LevelStats.level3 = false;
        LevelStats.level4 = false;

        LevelStats.level1Star = 0;
        LevelStats.level2Star = 0;
        LevelStats.level3Star = 0;
        LevelStats.level4Star = 0;

        UFOanim.intro = false;

        SceneManager.LoadScene("LevelSelection");
    }
}
