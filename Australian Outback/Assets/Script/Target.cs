using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Target : MonoBehaviour, IDamagable
{
    public float health = 100f;

<<<<<<< Updated upstream
=======
    public float currentHP;

    public int reward = 500;

    public Slider healthBar;

    Animator animator;

    [SerializeField]
    TMP_Text currentHealthText;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }
>>>>>>> Stashed changes
    public void Damage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
<<<<<<< Updated upstream
            Destroy(gameObject);
        }
    }
=======
            PlayerMoney.instance.getMoney(reward);
            animator.SetTrigger("die");
            Destroy(gameObject,1.5f);

            health = 0;
        }
    }

    void Update() 
    {
        currentHP = health;
        healthBar.value = health;
        currentHealthText.text = currentHP.ToString();
    }
>>>>>>> Stashed changes
}
