using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseHealth : MonoBehaviour
{

    public int HP = 100;
    public int currentHP;

    public Slider healthBar;

    [SerializeField]
    GameObject gameOverPanel;

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;

        if(HP <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            gameOverPanel.SetActive(true);
            //lose
            Debug.Log("You lose");
        }
    }

    public void Update()
    {
        healthBar.value = HP;
        currentHP= HP;
    }
}
