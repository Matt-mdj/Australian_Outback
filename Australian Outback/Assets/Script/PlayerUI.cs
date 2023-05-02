using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using StarterAssets;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] 
    TMP_Text ammoDisplay;

    [SerializeField]
    TMP_Text moneyDisplay;

    [SerializeField]
    TMP_Text speedDisplay;

    [SerializeField]
    TMP_Text jumpDisplay;

    [SerializeField]
    TMP_Text damageDisplay;

    [SerializeField]
    private GunData gunData;

    public FirstPersonController firstPersonCon;

    private void Update()
    {
        ammoDisplay.text = ("Ammo: ") + gunData.currentAmmo.ToString() + ("/") + gunData.magSize;

        moneyDisplay.text = ("Money: ") + PlayerMoney.instance.money.ToString();

        speedDisplay.text = ("Speed: ") + firstPersonCon.MoveSpeed.ToString();

        jumpDisplay.text = ("Jump: ") + firstPersonCon.JumpHeight.ToString();

        damageDisplay.text = ("Damge: ") + gunData.damage.ToString();
    }
}
