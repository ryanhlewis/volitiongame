using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigateMenu : MonoBehaviour
{
public GameObject character;
public GameObject settings;
public GameObject inventory;
public GameObject selector;
public GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

// Handles our navigation left, right, and the thingy that will go left/right
                if (Input.GetKeyDown(KeyCode.RightArrow))
        {
        if(inventory.activeInHierarchy) {

        inventory.SetActive(false);
        character.SetActive(true);
        selector.transform.Translate(transform.right * 16f);

        } else if (character.activeInHierarchy) {

            character.SetActive(false);
            settings.SetActive(true);
            background.SetActive(false);
            selector.transform.Translate(transform.right * 16f);
        }
        }  

            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {

        if(settings.activeInHierarchy) {

        settings.SetActive(false);
        character.SetActive(true);
        background.SetActive(true);
        selector.transform.Translate(transform.right * -16f);

        } else if (character.activeInHierarchy) {

            character.SetActive(false);
            inventory.SetActive(true);
            selector.transform.Translate(transform.right * -16f);
        }  

    
    }

//I want to handle our subscreen in another script only the Character object, to save RAM, etc.

}
}

