using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hero
{
    public GameObject prefabHero;
    public int health;
    public int cost;

    public GameObject GetHeroPrefabs()
    {
        return prefabHero;
    }

    public void SetHeroPrefabs(GameObject prefabHero)
    {
        this.prefabHero = prefabHero;
    }
    public int GetCost()
    {
        return cost;
    }
}
