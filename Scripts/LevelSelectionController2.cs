using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectionController2 : MonoBehaviour
{
    public GameObject level4;
    public GameObject level4fake;

    public GameObject L4Star1;
    public GameObject L4Star2;
    public GameObject L4Star3;

    // Start is called before the first frame update
    void Start()
    {
        L4Star1.SetActive(false);
        L4Star2.SetActive(false);
        L4Star3.SetActive(false);

        level4.SetActive(false);

        if (LevelStats.level3)
        {
            level4.SetActive(true);
            level4fake.SetActive(false);
        }

        if (LevelStats.level4Star == 1)
        {
            L4Star1.SetActive(true);
        }

        if (LevelStats.level4Star == 2)
        {
            L4Star1.SetActive(true);
            L4Star2.SetActive(true);
        }

        if (LevelStats.level4Star == 3)
        {
            L4Star1.SetActive(true);
            L4Star2.SetActive(true);
            L4Star3.SetActive(true);
        }
    }
}
