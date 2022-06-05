using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public Enemy[] enemydata;
    public GameObject enemy;
    public Transform[] spawnSpots;
    private float timeBtwSpawn;
    public float startTimeBtwSpawns;


    void Start()
    {
        timeBtwSpawn = startTimeBtwSpawns; 
    }
    void Update()
    {
        if(timeBtwSpawn <= 0)
        {
            int randPos = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
