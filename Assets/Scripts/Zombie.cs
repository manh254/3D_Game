using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    //public GameObject zombiePrefabs;
    public int zombieHealth;
    public float speed;
    public int moneyKilled;
    private Shop shop;

    public float range;

    public LayerMask shootMark;

    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
        shop = GameObject.Find("Shop").GetComponent<Shop>();
    }
    private void Update()
    {
        RaycastHit hit;
        bool isTargetSeen = Physics.Raycast(transform.position, transform.forward, out hit, range, shootMark);
        animator.SetBool("isAttacking", isTargetSeen);
        if (!isTargetSeen)
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }
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

    /*public void SetZombiePrefab(GameObject zombiePrefab)
    {
        this.zombiePrefabs = zombiePrefab;
    }*/
}
