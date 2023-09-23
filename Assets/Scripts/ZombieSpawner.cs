using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public ZombieBlueprint[] zombieBlueprint;
    private int cooldownSpawnZombie1;
    private int cooldownSpawnZombie2;
    private int cooldownSpawnZombie3;
    private float cooldownStartSpawnZombie2;
    private float cooldownStartSpawnZombie3;

    
    private void Start()
    {
        cooldownSpawnZombie1 = Random.Range(zombieBlueprint[0].minTimeSummon, zombieBlueprint[0].maxTimeSummon);
        cooldownSpawnZombie2 = Random.Range(zombieBlueprint[1].minTimeSummon, zombieBlueprint[1].maxTimeSummon);
        cooldownSpawnZombie3 = Random.Range(zombieBlueprint[2].minTimeSummon, zombieBlueprint[2].maxTimeSummon);

        /*InvokeRepeating("SpawnZombie1", 2, cooldownSpawnZombie1);
        InvokeRepeating("SpawnZombie2", 5, cooldownSpawnZombie2);
        InvokeRepeating("SpawnZombie3", 10, cooldownSpawnZombie3);*/
        StartCoroutine(SpawnZombie1());
        StartCoroutine(SpawnZombie2());
        StartCoroutine(SpawnZombie3());

    }

    
    IEnumerator SpawnZombie1()
    {
        
        for(int i = 0; i < zombieBlueprint[0].amount; i++)
        {
            yield return new WaitForSeconds(cooldownSpawnZombie1);
            int r = Random.Range(0, spawnPoints.Length);
            GameObject myZombie = Instantiate(zombieBlueprint[0].GetZombiePrefabs(), spawnPoints[r].position, Quaternion.identity);

            
        }
        
    }

    IEnumerator SpawnZombie2()
    {
        for (int i = 0; i < zombieBlueprint[1].amount; i++)
        {
            yield return new WaitForSeconds(cooldownSpawnZombie2);
            int r = Random.Range(0, spawnPoints.Length);
            GameObject myZombie = Instantiate(zombieBlueprint[1].GetZombiePrefabs(), spawnPoints[r].position, Quaternion.identity);

            
        }
    }

    IEnumerator SpawnZombie3()
    {
        for (int i = 0; i < zombieBlueprint[2].amount; i++)
        {
            yield return new WaitForSeconds(cooldownSpawnZombie3);
            int r = Random.Range(0, spawnPoints.Length);
            GameObject myZombie = Instantiate(zombieBlueprint[2].GetZombiePrefabs(), spawnPoints[r].position, Quaternion.identity);

            
        }
    }

}
