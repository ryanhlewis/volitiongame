using UnityEngine;
using System.Collections;

public class dismiss : MonoBehaviour
{
    public GameObject setdestination;
        public GameObject spaceship;
public GameObject launch; 
public GameObject map; 
public GameObject background;
public GameObject plane;
    public Animator spaceshipAnim;
    public GameObject buttons;
    public GameObject menu;

        public GameObject nameplate;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                    
    
    launch = GameObject.Find("/Canvas/MainMenu/Map/Launch");

if(launch.activeInHierarchy) {
print("hi");

launch.SetActive(false);

map = GameObject.Find("/Canvas/MainMenu/Map");

map.SetActive(true);

background = GameObject.Find("/Canvas/MainMenu/Map/Background");

background.SetActive(true);

plane = GameObject.Find("/Canvas/MainMenu/Map/Plane (1)");

plane.SetActive(true);


} 
 else {



nameplate.SetActive(true);

    setdestination = GameObject.Find("/Canvas/MainMenu/SetDestination");
    
    setdestination.SetActive(true);

spaceshipAnim = GameObject.Find("/Spaceship/Spaceship/Spaceship_Background_A").GetComponent<Animator>();

spaceshipAnim.Play("show");

buttons = GameObject.Find("/Canvas/MainMenu/Menu");

buttons.SetActive(true);

   gameObject.SetActive(false);

        }
    }
}
}