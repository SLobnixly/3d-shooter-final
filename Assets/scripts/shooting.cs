using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class shooting : MonoBehaviour
{
    public Camera cam;
    public GameObject enemySpawner;
    private EnemySpawner dying;
    private RaycastHit hit;
    private Ray ray;
    int points;
    public TMP_Text score;


    private void Start()
    {
        dying = GameObject.FindObjectOfType<EnemySpawner>();
    }
    // Update is called once per frame

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.name.Equals("Eprefab(Clone)"))
                {
                    dying.dead();
                    points++;
                    goob();
                    Destroy(hit.collider.gameObject);
                    Debug.Log("You are dead no big suprise");
                }

            }
        }







       
        
    }
    void goob()
    {
        score.text = $"score: {points}";
    }
}