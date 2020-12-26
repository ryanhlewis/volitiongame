using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
public GameObject spaceship;
public GameObject menu1;
public GameObject MainMenu;
public Animator spaceshipAnim;
public GameObject character;
public Animator characterAnim;
public GameObject EmblemTop;
    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        
         if(Input.GetKey(KeyCode.Mouse1)){

spaceshipAnim = spaceship.GetComponent<Animator>();

spaceshipAnim.Play("hide");

MainMenu.SetActive(false);

            menu1.SetActive(true);

EmblemTop.transform.SetParent(Camera.main.transform, true);

 //           characterAnim = character.GetComponent<Animator>();

//characterAnim.SetTrigger("Pressed");
         }
    }
}
