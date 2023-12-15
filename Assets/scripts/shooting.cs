using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class shooting : MonoBehaviour
{
    public Camera cam;
    public GameObject enemySpawner;

    private RaycastHit hit;
    private Ray ray;
    int points;
    public TMP_Text score;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag.Equals("npc"))
                {
                    Destroy(hit.collider.gameObject);
                    enemySpawner.GetComponent<EnemySpawner>().EnemyDied();
                    points++;
                    goob();
                }
            }
        }
        
    }
    void goob()
    {
        score.text = $"score: {points}";
    }
}