using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShooter : MonoBehaviour
{
    public int poolSize = 20;
    private Queue<GameObject> bulletPool = new Queue<GameObject>();

    public GameObject bullet;
    public Transform shootOrigin;
    public float cooldown = 0.0f;


    public float range;

    public LayerMask shootMark;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        for(int i = 0; i < poolSize; i++)
        {
            GameObject bulletIns = Instantiate(bullet, shootOrigin.position, Quaternion.identity);
            bulletIns.SetActive(false);
            bulletPool.Enqueue(bulletIns);
        }

    }
    private void Update()
    {
        RaycastHit hit;
        bool isTargetSeen = Physics.Raycast(transform.position, transform.forward, out hit, range, shootMark);
        animator.SetBool("isShooting", isTargetSeen);
    }

    public GameObject GetBulletFromPool()
    {
        if (bulletPool.Count > 0)
        {
            GameObject bulletIns = bulletPool.Dequeue();
            bulletIns.SetActive(true);
            return bulletIns;
        }
        else
        {
            
            return Instantiate(bullet, shootOrigin.position, Quaternion.identity);
        }
    }

    public void ReturnBulletToPool(GameObject bulletIns)
    {
        bulletIns.SetActive(false);
        bulletPool.Enqueue(bulletIns);
    }
}
