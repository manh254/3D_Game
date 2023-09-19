using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShooter : MonoBehaviour
{
    public int poolSize = 20;
    private Queue<GameObject> bulletPool = new Queue<GameObject>();

    public GameObject bullet;
    public Transform shootOrigin;
    public float cooldown;

    private bool canShoot;

    public float range;

    public LayerMask shootMark;

    private void Start()
    {
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
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, range, shootMark))
        {
            //Debug.Log("Seen");
            Shoot();
        }
    }

    private void ResetCooldown()
    {
        canShoot = true;
    }

    private void Shoot()
    {
        if (!canShoot)
        {
            return;
        }
        canShoot = false;
        Invoke("ResetCooldown", cooldown);
        GetBulletFromPool();
        //GameObject myBullet = Instantiate(bullet, shootOrigin.position, Quaternion.identity);
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
        Debug.Log("done");
        bulletPool.Enqueue(bulletIns);
    }
}
