using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ZombieBlueprint
{
    public GameObject zombiePrefabs;
    public int amount;
    public int minTimeSummon;
    public int maxTimeSummon;
    public GameObject GetZombiePrefabs()
    {
        return zombiePrefabs;
    }
}
