using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float zombieHealth;
    public float zombieCurrentHealth;
    public float speed;
    public int moneyKilled;
    public float damage;
    private Shop shop;

    private HealthBar healthBar;

    public float range;

    public LayerMask shootMark;

    private Animator animator;

    public EndGame endGame;

    private void Start()
    {
        zombieCurrentHealth = zombieHealth;
        healthBar = GetComponent<HealthBar>();
        animator = GetComponent<Animator>();
        shop = GameObject.Find("Shop").GetComponent<Shop>();
        endGame = GameObject.Find("EndGame").GetComponent <EndGame>();
    }
    private void Update()
    {
        if(transform.position.x < -3.5)
        {
            Destroy(gameObject);
            endGame.EndedGame();
        }

        RaycastHit hit;
        bool isTargetSeen = Physics.Raycast(transform.position, transform.forward, out hit, range, shootMark);
        animator.SetBool("isAttacking", isTargetSeen);
        
        if (!isTargetSeen)
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        healthBar.UpdateHealthBar(zombieHealth, zombieCurrentHealth);

    }

    public void Hit(float damage)
    {
        zombieCurrentHealth -= damage;
        if (zombieCurrentHealth <= 0)
        {
            Destroy(gameObject);
            shop.KilledZombie();
        }
    }

    public void ZombieAttack()
    {
        RaycastHit hit;
        bool isTargetSeen = Physics.Raycast(transform.position, transform.forward, out hit, range, shootMark);
        if (isTargetSeen)
        {
            hit.collider.GetComponent<Hero>().HeroTakeDamage(damage);
        }
    }


    public float GetMoneyKilled()
    {
        return moneyKilled;
    }

    public void SetZombieHealth(float zombieHealth)
    {
        this.zombieCurrentHealth = zombieHealth;
    }
    public float GetZombieHealth()
    {
        return zombieCurrentHealth;
    }

    public float GetZombieSpeed()
    {
        return speed;
    }
}
