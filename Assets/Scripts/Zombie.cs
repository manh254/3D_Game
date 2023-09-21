using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject zombiePrefabs;
    public int zombieHealth;
    public float speed;
    public int moneyKilled;
    private Shop shop;

    private void Start()
    {
        shop = GameObject.Find("Shop").GetComponent<Shop>();
    }
    private void FixedUpdate()
    {
        transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
    }

    public void Hit(int damage)
    {
        zombieHealth -= damage;
        if (zombieHealth <= 0)
        {
            Destroy(gameObject);
            shop.KilledZombie();
        }
    }

    public int GetMoneyKilled()
    {
        return moneyKilled;
    }

    public GameObject GetZombiePrefabs()
    {
        return zombiePrefabs;
    }

    public void SetZombieHealth(int zombieHealth)
    {
        this.zombieHealth = zombieHealth;
    }
    public int GetZombieHealth()
    {
        return zombieHealth;
    }

    public float GetZombieSpeed()
    {
        return speed;
    }

    public void SetZombiePrefab(GameObject zombiePrefab)
    {
        this.zombiePrefabs = zombiePrefab;
    }
}
