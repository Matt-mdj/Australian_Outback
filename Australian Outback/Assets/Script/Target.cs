using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour, IDamagable
{
    public float health;

    public Slider healthBar;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Damage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            animator.SetTrigger("die");
            Destroy(gameObject,1.5f);
        }
    }

    void Update() 
    {
        healthBar.value = health;
    }
}
