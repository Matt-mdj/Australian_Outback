using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float hitlast = 0f;
    public float attackDelay = 2f;

    public int damage = 10;
    void OnTriggerStay (Collider other)
    {

        if(other.gameObject.tag == "Stop")
        {
            if (Time.time - hitlast < attackDelay)
            {
                return;
            }
            other.GetComponent<HouseHealth>().TakeDamage(damage);
            
            hitlast= Time.time;
            print("Hit");
        }
    }
}
