using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class health : MonoBehaviour
{
    public int Health;
    public int nOfHearts;

    public Image[] hearts;

    public Sprite fullheart;
    public Sprite emptyHeart;

    public void  TakeDamage(int damage)
    { Health -= damage;
        Debug.Log("ouch");
    if (Health < 1) { Debug.Log("die)");
            Cursor.lockState = CursorLockMode.None;

            SceneManager.LoadScene("menu");
        }
       
    }
     void Update()
    {
        if (Health > nOfHearts) {Health = nOfHearts;}
    for (int i = 0; i < hearts.Length; i++)
        {

            if(i<Health) {hearts[i].sprite = fullheart; }
            else { hearts[i].sprite = emptyHeart; }
            
            if (i < nOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled=false;
            }
        }
    }


}
