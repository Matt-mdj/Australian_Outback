using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
            PlayerMoney.instance.getMoney(500);
            animator.SetTrigger("die");
            Destroy(gameObject,1f);

            health = 0;
        }
    }

    void Update() 
    {
        healthBar.value = health;
    }
}
