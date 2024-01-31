using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject Eprefab;





    public int enemyMax = 3;
    int enemys = 0;

    // Start is called before the first frame update
    private void Update()
    {
        if (enemys < 3) { 
          for (enemys = 0; enemys < enemyMax; enemys++)
        {
            
            GameObject enemy = Instantiate(Eprefab, transform.position, Quaternion.identity);
        }
    }
    }
      
    
    public void dead() 
    {
    enemys= enemys- 1;
    }
}

    
