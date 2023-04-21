using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{

    private int HP = 100;
    public Slider healthBar;
    
    //Call on this method once enemy collides with house
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if(HP <= 0)
        {
            //GAME OVER
        }
    }




    // Update is called once per frame
    void Update()
    {
        healthBar.value = HP;
    }
}
