using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using StarterAssets;


public class UIHandler : MonoBehaviour
{
    public GameObject Panel;
    public TextMeshProUGUI DamageText;
    public TextMeshProUGUI SpeedText;
    public TextMeshProUGUI JumpText;
    public static UIHandler instance;
    public FirstPersonController FirstPerson;
    public GunData Gun;
    
    private string moveSpeed;
    private string jumpSpeed;
    private string damageText;
    
    void Start (){
        
        Debug.Log(moveSpeed);
        
    } 

    void Update(){
        moveSpeed = FirstPerson.getMoveSpeed().ToString();
        jumpSpeed = FirstPerson.getJumpSpeed().ToString();
        damageText = Gun.getDamage().ToString();
        SpeedText.text = moveSpeed;
        JumpText.text = jumpSpeed;
        DamageText.text = damageText;
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

    public void updateSpeed(){

        if (PlayerMoney.instance.money >= 500)
        {
            FirstPerson.MoveSpeed = FirstPerson.MoveSpeed + 1;

            PlayerMoney.instance.spendMoney(500);
        }
        else
        {
            print("Broke bitch");
        }

    }

    public void updateJump(){

        if (PlayerMoney.instance.money >= 500)
        {
            FirstPerson.JumpHeight = FirstPerson.JumpHeight + 1;

            PlayerMoney.instance.spendMoney(500);
        }
        else
        {
            print("Broke bitch");
        }
    }

    public void updateDamage(){

        if (PlayerMoney.instance.money >= 500)
        {
            Gun.damage = Gun.damage + 5;

            PlayerMoney.instance.spendMoney(500);
        }
        else
        {
            print("Broke bitch");
        }
    }

    public void minusDamge(){
        Gun.damage =  Gun.damage - 5;
    }

    public void ClosePanel(){
        
        Panel.SetActive(false);
        Debug.Log("Close");
        Cursor.lockState = CursorLockMode.Locked; 
    }

    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
