using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    Vector3 firstPos;
    public GameObject holder;
    public GameObject switchh;

    // Start is called before the first frame update
    void Start()
    {
        firstPos = transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BallRes"))
        {
            holder.SetActive(true);
            transform.position = firstPos;
            SwitchhBall.green = false;
            switchh.GetComponent<SwitchhBall>().ColorGreen();
        }
    }
}
