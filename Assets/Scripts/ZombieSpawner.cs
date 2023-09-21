using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Zombie zombie;
    private void Start()
    {
        InvokeRepeating("SpawnZombie", 2, 5);
    }

    void SpawnZombie()
    {
        int r = Random.Range(0, spawnPoints.Length);
        GameObject myZombie = Instantiate(zombie.GetZombiePrefabs(), spawnPoints[r].position, Quaternion.identity);
    }

    
    
}
