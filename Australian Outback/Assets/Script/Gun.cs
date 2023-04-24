using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GunData gunData;
    [SerializeField] private Transform muzzle;

    float timeSinceLastShot;

    private bool CanShoot() => !gunData.reloading && timeSinceLastShot > 1f / (gunData.fireRate / 60f);
    private void Start()
    {
        PlayerShoot.shootInput += Shoot;
        PlayerShoot.reloadInput+= StartReload;
    }

    public void StartReload()
    {
        if(!gunData.reloading)
        {
            StartCoroutine(Reload());
        }
    }

    private IEnumerator Reload()
    {
        gunData.reloading = true;

        yield return new WaitForSeconds(gunData.reloadTime);

        gunData.currentAmmo = gunData.magSize;

        gunData.reloading = false;
    }
    public void Shoot()
    {
        if (gunData.currentAmmo > 0)
        {
            if(CanShoot())
            {
                if (Physics.Raycast(muzzle.position, muzzle.forward, out RaycastHit hitInfo, gunData.maxDistance)) 
                {
                    Debug.Log(hitInfo.transform.name);
                    IDamagable damagable = hitInfo.transform.GetComponent<IDamagable>();
                    damagable?.Damage(gunData.damage);

                }

                gunData.currentAmmo--;
                timeSinceLastShot = 0;
                OnGunShot();
            }
        }
    }


    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        Debug.DrawRay(muzzle.position,muzzle.forward, Color.yellow);
    }

    private void OnGunShot()
    {
    }
}