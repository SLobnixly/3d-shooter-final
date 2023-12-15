using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2.0f;
    public int maxEnemies = 5;
    private int currentEnemies = 0;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.0f, spawnInterval);
    }

   public  void SpawnEnemy()
    {
        if (currentEnemies < maxEnemies)
        {
            GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            if (newEnemy != null)
            {
                currentEnemies++;
            }
            else
            {
                Debug.LogError("Failed to instantiate enemy!");
            }
        }
    }
    public void EnemyDied()
    {currentEnemies-=1;}
}