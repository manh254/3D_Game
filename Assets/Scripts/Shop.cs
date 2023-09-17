using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    //public Sprite heroSprite;
    public GameObject heroObject;

    private BuildingSystem buildingSystem;
    private void Start()
    {
        buildingSystem = GameObject.Find("BuildingSystem").GetComponent<BuildingSystem>();
        GetComponent<Button>().onClick.AddListener(BuyHero);
    }

    private void BuyHero()
    {
        buildingSystem.BuyHero(heroObject);
        Debug.Log("Buyed");
    }

    private void OnValidate()
    {
        
    }
}
