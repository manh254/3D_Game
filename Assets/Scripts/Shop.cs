using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    //public Sprite heroSprite;
    public Hero[] hero;
    private Hero heroToBuyed;
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
    public void BuyHeroSuccess(Hero hero)
    {
        money -= hero.GetCost();
        //Debug.Log(heroToBuyed.GetCost().ToString());
    }   
    
    //add money from killed zombie
    public void KilledZombie()
    {
        money += zombie.GetMoneyKilled();
    }

    //Onclick by user
    public void BuyHero1()
    {
        heroToBuyed = hero[0];
        BuyHero();
    }
    public void BuyHero2()
    {
        heroToBuyed = hero[1];
        BuyHero();
    }
    public void BuyHero3()
    {
        heroToBuyed = hero[2];
        BuyHero();
    }
    public void BuyHero4()
    {
        heroToBuyed = hero[3];
        BuyHero();
    }
    public void BuyHero5()
    {
        heroToBuyed = hero[4];
        BuyHero();
    }
}
