using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipes;
    public Transform[] spawnPoint;

    private int randPosition;
    public float timeForSpawn;
    private float timeBtwSpawn;


    void Start()
    {
        timeBtwSpawn = timeForSpawn;
    }

    
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            randPosition = Random.Range(0, spawnPoint.Length);
            Instantiate(pipes, spawnPoint[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawn = timeForSpawn;
        }
        else 
        {
            timeBtwSpawn -= Time.deltaTime;
        }

    }
}
