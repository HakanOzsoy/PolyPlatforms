using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminPower : MonoBehaviour
{
    public void OnMouseDown()
    {
        LevelStats.level1 = true;
        LevelStats.level2 = true;
        LevelStats.level3 = true;
    }
}
