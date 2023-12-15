using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemysearch : MonoBehaviour
{
    public Transform Player;
    public float AttackRange = 6f;
    private bool foundyou;
    private enemy enemyScript;

    public Renderer ren;
    public Material defaultMaterial;
    public Material alertMaterial;
    // Start is called before the first frame update
   

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        ren = GetComponent<Renderer>();
        enemyScript = GetComponent<enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) <= AttackRange)
        {
            ren.sharedMaterial = alertMaterial;
            enemyScript.badguy.SetDestination(Player.position);
            foundyou = true;
        }
        else if (foundyou)
        {
            ren.sharedMaterial = defaultMaterial;
            enemyScript.newLocation();
            foundyou = false;
        }
    }
}