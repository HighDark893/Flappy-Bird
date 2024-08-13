using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawmer : MonoBehaviour
{
    public GameObject enemyPrefab; // The enemy prefab to spawn
    public float spawnInterval = 2f; // Time interval between spawns
    public Transform[] spawnPoints; // Array of spawn points

    private float timeSinceLastSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        // Check if it's time to spawn a new enemy
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0f; // Reset the spawn timer
        }
    }
    void SpawnEnemy()
    {
        // Randomly choose a spawn point
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];

        // Instantiate the enemy at the chosen spawn point
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

    }
}
