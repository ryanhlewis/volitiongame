using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subscreenScript : MonoBehaviour
{
public GameObject subscreen;
public GameObject main;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

// Handles our navigation left, right, and the thingy that will go left/right
                if (Input.GetKeyDown(KeyCode.DownArrow))
        {
        if(main.activeInHierarchy) {

        main.SetActive(false);
        subscreen.SetActive(true);
        
        //Some animation to go from top to bottom
        //selector.transform.Translate(transform.right * 16f);

        }
        } 

                if (Input.GetKeyDown(KeyCode.UpArrow))
        {
        if(subscreen.activeInHierarchy) {

        subscreen.SetActive(false);
        main.SetActive(true);
        
        //Some animation to go from top to bottom
        //selector.transform.Translate(transform.right * 16f);

        } 




//I want to handle our subscreen in another script only the Character object, to save RAM, etc.

}
}
    }


