using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCheck : MonoBehaviour
{
    public GameObject Player;
    public GameObject TouchControls;

    // Start is called before the first frame update
    void Start()
    {
        Player.SetActive(false);
        TouchControls.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            Invoke("PlayerSpawn", 1.5f);
        }
    }

    void PlayerSpawn()
    {
        TouchControls.SetActive(true);
        Player.SetActive(true);
        Destroy(gameObject);
    }
}
