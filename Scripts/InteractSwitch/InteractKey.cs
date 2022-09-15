using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractKey : MonoBehaviour
{
    public static bool key;
    public GameObject player;
    public GameObject konum;
    public GameObject locked;

    Vector3 endPos;

    // Start is called before the first frame update
    void Start()
    {
        locked.SetActive(false);
        endPos = konum.transform.position;
        key = false;
    }

    public void OnClick()
    {
        if (key)
        {
            player.transform.position = endPos;
        }

        if(key == false)
        {
            CancelInvoke();
            locked.SetActive(true);
            Invoke("lockedUI", 1);
        }
    }

    void lockedUI()
    {
        locked.SetActive(false);
    }
}
