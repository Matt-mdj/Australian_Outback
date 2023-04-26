using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    Vector3 rot=Vector3.zero;
    float degpersec = 6;
    bool canRotate = true;
    float delay = 2f; // Delay in seconds
    Vector3 zeroRot;
    float checkDelay = 40f; // Delay in seconds before checking for enemies
    float checkTimer = 0f; // Timer to keep track of the delay


    // Update is called once per frame
    void Update()
    {
       
        if (canRotate)
        {
                
            rot.x = degpersec * Time.deltaTime;
                transform.Rotate(rot, Space.World);
        }

        if (checkTimer >= checkDelay)
        {
            // Check for enemies with the tag "Enemy"
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            // Stop rotating if enemies are present
            if (enemies.Length > 0)
            {
                canRotate = false;
            }
            // Resume rotating if no enemies are present
            else
            {
                new Vector3(0f, transform.eulerAngles.y, transform.eulerAngles.z);
                transform.rotation = Quaternion.Euler(zeroRot);
                canRotate = true;
                checkTimer = 0f;
                StartCoroutine(ResumeRotation(delay));
            }
            // Reset the timer
                
        }
        else
        {
            // Increment the timer
            checkTimer += Time.deltaTime;
        }
    }

    IEnumerator ResumeRotation(float delay)
    {
        yield return new WaitForSeconds(delay);
        canRotate = true;
    }
}

//transform.localEularAngles = new Vector3(0,0,0);