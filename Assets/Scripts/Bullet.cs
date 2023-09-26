using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public float speed = 0.8f;
    public BasicShooter shooter;
    
    private void Update()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        BulletOutDisplay();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Zombie>(out Zombie zombie))
        {

            zombie.Hit(damage);
            
            shooter.ReturnBulletToPool(gameObject);
        }
    }

    private void BulletOutDisplay()
    {
        if(transform.position.x >= 10f)
            shooter.ReturnBulletToPool(gameObject);
    }
}
