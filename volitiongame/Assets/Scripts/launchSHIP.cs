using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class launchSHIP : MonoBehaviour
{
    public Button aButton;
public GameObject MainMenu;
public GameObject spaceship;
public GameObject camera;
public Animator spaceshipAnim;
public Animator cameraAnim;

    // Start is called before the first frame update
    void Start()
    {
        		Button launchButton = aButton.GetComponent<Button>();
		launchButton.onClick.AddListener(LaunchClick);
    }

    // Update is called once per frame

	void LaunchClick(){

MainMenu.SetActive(false);


spaceshipAnim = spaceship.GetComponent<Animator>();

spaceshipAnim.Play("fly");

cameraAnim = camera.GetComponent<Animator>();

cameraAnim.Play("camerarotaet");


    }

//I want to handle our subscreen in another script only the Character object, to save RAM, etc.


}

