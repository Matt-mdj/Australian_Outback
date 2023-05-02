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
    private GunData gunData;

    [SerializeField]
    TMP_Text moneydisplay;

    [SerializeField]
    TMP_Text speedDisplay;

    [SerializeField]
    TMP_Text JumpDisplay;

    [SerializeField]
    TMP_Text DamageDisplay;

    public FirstPersonController firstPersonCon;

    private void Update()
    {
        ammoDisplay.text = ("Ammo:") + gunData.currentAmmo.ToString() + ("/") + gunData.magSize;

        moneydisplay.text = ("Money: ") + PlayerMoney.instance.money.ToString();

        speedDisplay.text = ("Speed: ") + firstPersonCon.MoveSpeed.ToString();

        JumpDisplay.text = ("Jump: ") + firstPersonCon.JumpHeight.ToString();

        DamageDisplay.text = ("Damage: ") + gunData.damage.ToString();
    }
}
