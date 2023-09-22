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

    //private bool canShoot;

    public float range;

    public LayerMask shootMark;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        Invoke("ResetCooldown", cooldown);
        for(int i = 0; i < poolSize; i++)
        {
            GameObject bulletIns = Instantiate(bullet, shootOrigin.position, Quaternion.identity);
            bulletIns.SetActive(false);
            bulletPool.Enqueue(bulletIns);
        }

    }
    private void Update()
    {
        if(cooldown >= 1.0f)
        {
            cooldown = 0.0f;
        }
        RaycastHit hit;
        bool isTargetSeen = Physics.Raycast(transform.position, transform.forward, out hit, range, shootMark);
        animator.SetBool("isShooting", isTargetSeen);
        if (isTargetSeen && cooldown == 0.0f)
        {
            //GetBulletFromPool();
        }
        cooldown += Time.deltaTime;
        Debug.Log(cooldown.ToString());
    }

    /*private void ResetCooldown()
    {
        canShoot = true;
        
    }*/

    /*private void Shoot()
    {
        if (!canShoot)
        {
            return;
        }
        canShoot = false;

        Invoke("ResetCooldown", cooldown);
        
        GetBulletFromPool();
    }*/

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
