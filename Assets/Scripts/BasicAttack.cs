using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack : MonoBehaviour
{
    public int damage;

    public float range;

    public LayerMask shootMark;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        RaycastHit hit;
        bool isTargetSeen = Physics.Raycast(transform.position, transform.forward, out hit, range, shootMark);
        animator.SetBool("isAttacking", isTargetSeen);
    }

    public void HeroAttack()
    {
        RaycastHit hit;
        bool isTargetSeen = Physics.Raycast(transform.position, transform.forward, out hit, range, shootMark);
        if (isTargetSeen)
        {
            hit.collider.GetComponent<Zombie>().Hit(damage);
        }
    }
}
