using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dismissPop : MonoBehaviour
{

	public Button setDestination;
    	public Button namePlate;




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                    
setDestination.interactable = true;
namePlate.interactable = true;

gameObject.SetActive(false);



        }
    }
}
