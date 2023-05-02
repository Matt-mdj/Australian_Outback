using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public int money = 0;

    public static PlayerMoney instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void getMoney(int income)
    {
        money += income;
    }

    public void spendMoney(int expence)
    {
        money -= expence;
    }
}
