using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float heroHealth;
    private float heroCurrentHealth;
    //public Node node;
    private HealthBar healthBar;

    public float range;

    public LayerMask shootMark;
    private void Start()
    {
        heroCurrentHealth = heroHealth;
        healthBar = GetComponent<HealthBar>();
    }

    private void Update()
    {
        healthBar.UpdateHealthBar(heroHealth, heroCurrentHealth);
    }

    public void TakeNode()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit))
        {
            GameObject hitObject = hit.collider.gameObject;
            hitObject.GetComponent<Node>().ResetNode();
        }
    }

    public void HeroTakeDamage(float damage)
    {
        heroCurrentHealth -= damage;
        if(heroCurrentHealth <= 0)
        {
            TakeNode();
            Destroy(gameObject);
        }
    }

    /*private void OnMouseDown()
    {
        Destroy(gameObject);
        TakeNode();
    }*/
}
