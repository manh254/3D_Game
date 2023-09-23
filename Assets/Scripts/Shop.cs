using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    //public Sprite heroSprite;
    public HeroBlueprint[] heroBlueprint;
    private HeroBlueprint heroToBuyed;

    //private Zombie zombie;
    public int money;
    public TextMeshProUGUI moneyToBuy;
    private BuildingSystem buildingSystem;

    public Zombie zombie;
    private void Start()
    {
        buildingSystem = GameObject.Find("BuildingSystem").GetComponent<BuildingSystem>();
        
    }

    private void Update()
    {
        moneyToBuy.text = money.ToString();
    }

    private void BuyHero()
    {
        buildingSystem.BuyHero(heroToBuyed);
        //Debug.Log("Buyed");
    }

    //subtract money to buy hero
    public void BuyHeroSuccess(HeroBlueprint heroBlueprint)
    {
        money -= heroBlueprint.GetCost();
        //Debug.Log(heroToBuyed.GetCost().ToString());
    }   
    
    //add money from killed zombie
    public void KilledZombie()
    {
        money += zombie.GetMoneyKilled();
    }

    public int GetMoney()
    {
        return money;
    }

    //Onclick by user
    public void BuyHero1()
    {
        heroToBuyed = heroBlueprint[0];
        BuyHero();
    }
    public void BuyHero2()
    {
        heroToBuyed = heroBlueprint[1];
        BuyHero();
    }
    public void BuyHero3()
    {
        heroToBuyed = heroBlueprint[2];
        BuyHero();
    }
    public void BuyHero4()
    {
        heroToBuyed = heroBlueprint[3];
        BuyHero();
    }
    public void BuyHero5()
    {
        heroToBuyed = heroBlueprint[4];
        BuyHero();
    }
}
