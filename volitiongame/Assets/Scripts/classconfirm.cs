using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class classconfirm : MonoBehaviour
{
    // Start is called before the first frame update

public Animator transitionAnim;
public GameObject Rogue; 
public GameObject Knight;
public GameObject Mage; 

public GameObject Class;
public GameObject Name;
public GameObject InputField;

 private void Start(){

 }

string playerclass = "unknown";

    void Update () {


        if (Input.GetKeyDown(KeyCode.Return))
        {
           

            if (Rogue.gameObject.activeInHierarchy) {
            playerclass = "Rogue";
            Continue();
            }

            if (Mage.gameObject.activeInHierarchy) {
            playerclass = "Mage";
            Continue();
            }

            if (Knight.gameObject.activeInHierarchy) {
            playerclass = "Knight";
            Continue();
            }

            
        }
    }




        void Continue () {


Name.SetActive(true);
InputField.SetActive(true);
Class.SetActive(false);



        }

    }


 



