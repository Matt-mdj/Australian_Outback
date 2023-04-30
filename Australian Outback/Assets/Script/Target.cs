using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour, IDamagable
{
    public float health = 100f;

    public Slider healthBar;

    public void Damage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Update() 
    {
        healthBar.value = health;
    }
}
