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
    TMP_Text SpeedDisplay;

    [SerializeField]
    TMP_Text JumpDisplay;

    [SerializeField]
    TMP_Text DamageDisplay;

    [SerializeField]
    private GunData gunData;

    [SerializeField]
    FirstPersonController fpsController;

    private void Update()
    {
        ammoDisplay.text = ("Ammo: ") + gunData.currentAmmo.ToString() + ("/") + gunData.magSize;

        moneyDisplay.text = ("Money: ") + PlayerMoney.instance.money.ToString();

        SpeedDisplay.text = ("Speed: ") + fpsController.MoveSpeed.ToString();

        JumpDisplay.text = ("Jump: ") + fpsController.JumpHeight.ToString();

        DamageDisplay.text = ("Damage: ") + gunData.damage.ToString();
    }
}
