using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadOrbit : MonoBehaviour
{
    // Start is called before the first frame update

public Animator transitionAnim;
public GameObject TitleStuff; 
public GameObject Class; 
public Canvas myCanvas;
public CanvasGroup group;

 private void Start(){

group = myCanvas.GetComponent<CanvasGroup>();
transitionAnim = myCanvas.GetComponent<Animator>();

 }

//Changing this to true. I made this so long ago, and forgot what I was trying to accomplish here. Maybe a smooth transition fade? 
bool begun = false;


//It seems I made this to control a transition from the Start Screen to the Class screen, and the Orbit never actually runs because TitleStuff is set to false, and therefore this entire script is never run again.
//Lesson: Don't have misleading cs titles. 

    void Update () {


        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (begun == true)
            Enter ("Orbit");

            if (begun == false) {
            begun = true;

Class.SetActive(true);

transitionAnim.Play("fade");



TitleStuff.SetActive(false);

            }
        }

    }



  void Enter(string scene) {

     SceneManager.LoadScene(scene);

 }
 


}
