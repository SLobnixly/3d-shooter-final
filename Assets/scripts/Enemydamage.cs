using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydamage : MonoBehaviour
{
    int damage;

    health Health;
    EnemySpawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        damage = Random.Range(1, 3);
        Health = GameObject.FindGameObjectWithTag("Player").GetComponent<health>();
        spawner = GameObject.FindGameObjectWithTag("spawner").GetComponent<EnemySpawner>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("guh!!");
            Health.TakeDamage(damage);
            spawner.EnemyDied();
            Destroy(gameObject);
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
