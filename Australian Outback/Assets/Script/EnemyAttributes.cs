using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttributes : MonoBehaviour
{
    public int health;
    public int damange;

    public bool isDead;

    public void TakeDamage(int damage)
    {
        health-= damage;

        if (health < 0)
        {
            isDead = true;
            health= 0;
        }
    }
}
