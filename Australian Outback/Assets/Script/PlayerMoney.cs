using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public int money;

    public static PlayerMoney instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void getMoney(int amount)
    {
        money += amount;
    }

    public void spendMoney(int amount)
    {
        money -= amount;
    }
}
