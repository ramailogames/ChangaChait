using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles;
    [SerializeField] GameObject cluster;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] Transform clusterSpawnPoint;

    [SerializeField] float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2, spawnDelay);
        InvokeRepeating("Spawn_", 5, 5);
    }

  

    void Spawn()
    {
        int index = Random.Range(0, obstacles.Length);
        int index_ = Random.Range(0, spawnPoints.Length);
        Instantiate(obstacles[index], spawnPoints[index_].position, spawnPoints[index_].rotation);
    }

    void Spawn_()
    {
        Instantiate(cluster, clusterSpawnPoint.position, clusterSpawnPoint.rotation);
    }
}
