using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractOutro : MonoBehaviour
{
    public GameObject player;
    public GameObject konum;

    Vector3 endPos;

    // Start is called before the first frame update
    void Start()
    {
        endPos = konum.transform.position;
    }

    public void OnClick()
    {
        player.transform.position = endPos;
    }
}
