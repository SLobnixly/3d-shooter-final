using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public NavMeshAgent badguy;
    private float xmin;
    private float xmax;
    private float zmin;
    private float zmax;

    private float xposition;
    private float yposition;
    private float zposition;


    public float squareofmovement = 20f;

    public float closeEnough = 3f;




    // Start is called before the first frame update
    void Start()
    {
        xmin = zmin = -squareofmovement;
        xmax = zmax = squareofmovement;
        newLocation();

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, new Vector3(xposition, yposition, zposition)) <= closeEnough)
        {
            newLocation();
        }


    }


    public void newLocation()
    {
        xposition = Random.Range(xmin, xmax);
        yposition = transform.position.y;
        zposition = Random.Range(zmin, zmax);
        badguy.SetDestination(new Vector3(xposition, yposition, zposition));

    }


}