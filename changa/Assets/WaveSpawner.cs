using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles;
    [SerializeField] GameObject cluster;
    [SerializeField] GameObject crow;
    [SerializeField] GameObject enemyKite;

    [SerializeField] Transform[] spawnPoints;
    [SerializeField] Transform clusterSpawnPoint;
    [SerializeField] Transform[] crowSpawnPoints;
    [SerializeField] Transform enemyKitePoint;

    [SerializeField] float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2, spawnDelay);
        InvokeRepeating("Spawn_", 5, 5);
        InvokeRepeating("CrowAndKite", 4,7);
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

    void CrowAndKite()
    {
        int index = Random.Range(1, 3);
        if(index > 1)
        {
            // SpawnKite();
            SpawnKite();
            return;
        }
        SpawnCrow();
    }

    void SpawnCrow()
    {
        int csp = Random.Range(0, crowSpawnPoints.Length);
        Instantiate(crow, crowSpawnPoints[csp].position, crowSpawnPoints[csp].rotation);
    }
    
    void SpawnKite()
    {
        GameObject ktie =  Instantiate(enemyKite, enemyKitePoint.position, enemyKitePoint.rotation);
        ktie.transform.SetParent(enemyKitePoint);
        ktie.transform.parent = enemyKitePoint;


    }


}
