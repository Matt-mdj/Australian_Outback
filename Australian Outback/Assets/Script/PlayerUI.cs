using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] 
    TMP_Text ammoDisplay;

    [SerializeField]
    private GunData gunData;

    private void Update()
    {
        ammoDisplay.text = gunData.currentAmmo.ToString() + ("/") + gunData.magSize;
    }
}
