using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public GameObject Panel;
    // public TextMeshProUGUI LevelStatus;
    // public TextMeshProUGUI scoreText;
    public static UIHandler instance;

     void Awake()
    {
        if (instance == null){
            instance = this;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit " + collision.gameObject.name);
            Panel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    // public void ShowPanel()
    // {
    //     if (Panel.activeInHierarchy == false){
    //     Panel.SetActive(true);
    //     }
    //     // LevelStatus.text = status;
    //     // scoreText.text = scores;
    // }

    public void ClosePanel(){
        
        Panel.SetActive(false);
        Debug.Log("Close");
        Cursor.lockState = CursorLockMode.Locked; 
    }
}
