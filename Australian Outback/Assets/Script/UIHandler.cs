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

    

    public void ShowPanel()
    {
        Panel.SetActive(true);
        // LevelStatus.text = status;
        // scoreText.text = scores;
    }
}
