using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
 
    private EnemySpawner enemySpawner;
    
    // Start is called before the first frame update
    void Start()
    {
       
      
      
    }

    public void TakeDamage()
    {

        Die();
        
    }

  public  void Die()
    {
       
        Destroy(gameObject); // Destroy the enemy object
    }
}