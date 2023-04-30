using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public static Action shootInput;
    public static Action reloadInput;
    public AudioSource shotSound;
    public AudioSource reloadSound;

    [SerializeField] private KeyCode reloadKey;
    Animator anim;
 
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            shootInput?.Invoke();
            anim.SetTrigger("Active");
            shotSound.Play();
           
        }

        if(Input.GetKeyDown(reloadKey))
        {
            reloadInput?.Invoke();
            reloadSound.Play();
        }
    }
}
