using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectionController : MonoBehaviour
{
    public GameObject level2;
    public GameObject level2fake;
    public GameObject level3;
    public GameObject level3fake;

    public GameObject L1Star1;
    public GameObject L1Star2;
    public GameObject L1Star3;

    public GameObject L2Star1;
    public GameObject L2Star2;
    public GameObject L2Star3;

    public GameObject L3Star1;
    public GameObject L3Star2;
    public GameObject L3Star3;
    // Start is called before the first frame update
    void Start()
    {
        L1Star1.SetActive(false);
        L1Star2.SetActive(false);
        L1Star3.SetActive(false);

        L2Star1.SetActive(false);
        L2Star2.SetActive(false);
        L2Star3.SetActive(false);

        L3Star1.SetActive(false);
        L3Star2.SetActive(false);
        L3Star3.SetActive(false);

        level2.SetActive(false);
        level3.SetActive(false);

        if (LevelStats.level1)
        {
            level2.SetActive(true);
            level2fake.SetActive(false);
        }

        if (LevelStats.level2)
        {
            level3.SetActive(true);
            level3fake.SetActive(false);
        }

        // LEVEL 1 STARS

        if (LevelStats.level1Star == 1)
        {
            L1Star1.SetActive(true);
        }

        if (LevelStats.level1Star == 2)
        {
            L1Star1.SetActive(true);
            L1Star2.SetActive(true);
        }

        if (LevelStats.level1Star == 3)
        {
            L1Star1.SetActive(true);
            L1Star2.SetActive(true);
            L1Star3.SetActive(true);
        }

        // LEVEL 2 STARS

        if (LevelStats.level2Star == 1)
        {
            L2Star1.SetActive(true);
        }

        if (LevelStats.level2Star == 2)
        {
            L2Star1.SetActive(true);
            L2Star2.SetActive(true);
        }

        if (LevelStats.level2Star == 3)
        {
            L2Star1.SetActive(true);
            L2Star2.SetActive(true);
            L2Star3.SetActive(true);
        }

        // LEVEL 3 STARS

        if (LevelStats.level3Star == 1)
        {
            L3Star1.SetActive(true);
        }

        if (LevelStats.level3Star == 2)
        {
            L3Star1.SetActive(true);
            L3Star2.SetActive(true);
        }

        if (LevelStats.level3Star == 3)
        {
            L3Star1.SetActive(true);
            L3Star2.SetActive(true);
            L3Star3.SetActive(true);
        }
    }
}
