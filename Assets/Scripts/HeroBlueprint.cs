using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HeroBlueprint
{
    public GameObject prefabs;
    public int cost;

    public int GetCost()
    {
        return cost;
    }

    public GameObject GetHeroPrefabs()
    {
        return prefabs;
    }
}
