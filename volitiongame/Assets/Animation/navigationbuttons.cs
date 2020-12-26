using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class navigationbuttons : MonoBehaviour {
	public Button invButton;
    public Button charButton;
    public Button settButton;
    public GameObject character;
    public GameObject inventory;
    public GameObject settings;
    public GameObject selector;
    public GameObject background;

	void Start () {
		Button inventoryButton = invButton.GetComponent<Button>();
		inventoryButton.onClick.AddListener(InventoryClick);
        		Button characterButton = charButton.GetComponent<Button>();
		characterButton.onClick.AddListener(CharacterClick);
        		Button settingsButton = settButton.GetComponent<Button>();
		settingsButton.onClick.AddListener(SettingsClick);
	}

	void InventoryClick(){

if (character.activeInHierarchy) {

            character.SetActive(false);
            inventory.SetActive(true);
            selector.transform.Translate(transform.right * -16f);


        } else if(settings.activeInHierarchy) {

        settings.SetActive(false);
        inventory.SetActive(true);
        background.SetActive(true);
        selector.transform.Translate(transform.right * -32f);

        } 
    }

    	void CharacterClick(){

if (settings.activeInHierarchy) {

            settings.SetActive(false);
            character.SetActive(true);
            background.SetActive(true);
            selector.transform.Translate(transform.right * -16f);


        } else if(inventory.activeInHierarchy) {

        inventory.SetActive(false);
        character.SetActive(true);
        selector.transform.Translate(transform.right * 16f);

        } 
    }

	void SettingsClick(){

if (character.activeInHierarchy) {

            character.SetActive(false);
            settings.SetActive(true);
            background.SetActive(false);
            selector.transform.Translate(transform.right * 16f);


        } else if(inventory.activeInHierarchy) {

        inventory.SetActive(false);
        settings.SetActive(true);
        background.SetActive(false);
        selector.transform.Translate(transform.right * 32f);

        } 
    }


	}
    
    

    
