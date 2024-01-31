using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydamage : MonoBehaviour
{
    int damage;

    health Health;
    
    // Start is called before the first frame update
    void Start()
    {
        damage = Random.Range(1, 2);
        Health = GameObject.FindGameObjectWithTag("Player").GetComponent<health>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.name == "playerPrefab")
        {
            Debug.Log("guh!!");
            Health.TakeDamage(damage);

            Destroy(gameObject);

        }
       
    }

    
     

    // Update is called once per frame
    void Update()
    {

    }
}
