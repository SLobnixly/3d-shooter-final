using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private EnemySpawner enemySpawner;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject spawnerObject = GameObject.FindWithTag("spawner");

        if (spawnerObject != null)
        {
            enemySpawner = spawnerObject.GetComponent<EnemySpawner>();
        }
      
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount )
    {
        currentHealth -= damageAmount;

        // Check if the enemy's health is depleted
        if (currentHealth <= 0)
        {
            Die();
        }
    }

  public  void Die()
    {
        enemySpawner.SpawnEnemy();
        Destroy(gameObject); // Destroy the enemy object
    }
}