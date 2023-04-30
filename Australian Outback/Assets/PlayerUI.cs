using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] 
    Text ammoDisplay;

    [SerializeField]
    private GunData gunData;

    private void Update()
    {
        ammoDisplay.text = gunData.currentAmmo.ToString();
    }
}
