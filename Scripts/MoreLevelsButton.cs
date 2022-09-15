using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoreLevelsButton : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("LevelSelection2");
    }
}
