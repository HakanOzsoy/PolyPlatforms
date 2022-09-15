using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSpike : MonoBehaviour
{
    SpriteRenderer Srenderer;

    // Start is called before the first frame update
    void Start()
    {
        Srenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Srenderer.color = new Color(0f, 0f, 0f, 1f);
            Invoke("RestartScene", 0.1f);
            Time.timeScale = 0.1f;
            Coin.LevelCoins = 0;
        }
    }

    void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
