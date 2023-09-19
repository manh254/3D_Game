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
    /*public void SetShooter(BasicShooter shooter)
    {
        this.shooter = shooter;
    }*/
    private void Update()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
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
}
