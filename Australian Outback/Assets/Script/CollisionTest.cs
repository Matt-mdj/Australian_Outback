using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    public int damage = 10;
    GameObject house;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Test")
        {
            house.GetComponent<House>().TakeDamage(damage);
        }
    }
}
