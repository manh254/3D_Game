using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    //public Sprite heroSprite;
    public GameObject[] heroObject;
    private GameObject heroToBuyed;

    private BuildingSystem buildingSystem;
    private void Start()
    {
        buildingSystem = GameObject.Find("BuildingSystem").GetComponent<BuildingSystem>();
        //GetComponent<Button>().onClick.AddListener(BuyHero);
    }

    private void BuyHero()
    {
        buildingSystem.BuyHero(heroToBuyed);
        //Debug.Log("Buyed");
    }

    private void OnValidate()
    {

    }

    public void BuyHero1()
    {
        heroToBuyed = heroObject[0];
        BuyHero();
    }
    public void BuyHero2()
    {
        heroToBuyed = heroObject[1];
        BuyHero();
    }
    public void BuyHero3()
    {
        heroToBuyed = heroObject[2];
        BuyHero();
    }
    public void BuyHero4()
    {
        heroToBuyed = heroObject[3];
        BuyHero();
    }
    public void BuyHero5()
    {
        heroToBuyed = heroObject[4];
        BuyHero();
    }
}
