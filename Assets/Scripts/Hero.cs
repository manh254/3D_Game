using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public int heroHealth;
    private int heroCurrentHealth;
    public Node node;

    public float range;

    public LayerMask shootMark;
    private void Start()
    {
        heroCurrentHealth = heroHealth;
    }

    /*private void Update()
    {
        
    }*/
    public void TakeNode()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit))
        {
            GameObject hitObject = hit.collider.gameObject;
            hitObject.GetComponent<Node>().ResetNode();
        }
    }

    public void HeroTakeDamage(int damage)
    {
        heroCurrentHealth -= damage;
        if(heroCurrentHealth < 0)
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
