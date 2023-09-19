using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int zombieHealth;
    public float speed;

    private void FixedUpdate()
    {
        transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
    }

    public void Hit(int damage)
    {
        zombieHealth -= damage;
        if(zombieHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
