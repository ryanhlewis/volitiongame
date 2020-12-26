using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dismissMenu : MonoBehaviour
{
public GameObject spaceship;
public GameObject menu1;
public GameObject MainMenu;
public Animator spaceshipAnim;
public GameObject EmblemTop;
public Transform menu1transform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


                if (Input.GetKeyDown(KeyCode.Escape) /*|| Input.GetKey(KeyCode.Mouse1)*/)
        {
             spaceshipAnim = spaceship.GetComponent<Animator>();

spaceshipAnim.Play("show");

MainMenu.SetActive(true);
       
EmblemTop.transform.SetParent(menu1transform);

            menu1.SetActive(false);

        }   
    }
}
