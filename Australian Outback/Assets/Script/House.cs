using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class House : MonoBehaviour
{

    private int HP = 100;
    public Slider healthBar;
    public static bool isGameOver;

    public TextMeshProUGUI HouseHPtext;

    private void Start()
    {
        isGameOver = false;
    }

    //Call on this method once enemy collides with house
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if(HP <= 0)
        {
            //GAME OVER
            isGameOver = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        HouseHPtext.text = HP.ToString();
        healthBar.value = HP;

        if (isGameOver )
        {
            // Game Over Screen
        }
    }
}
