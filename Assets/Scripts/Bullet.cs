using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    public float speed = 0.8f;
    public BasicShooter shooter;

    /*private void Start()
    {
        shooter = new BasicShooter();
    }*/
    
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
            Debug.Log("hit");
        }
    }

    private void BulletOutDisplay()
    {
        if(transform.position.x >= 10f)
            shooter.ReturnBulletToPool(gameObject);
    }
}
