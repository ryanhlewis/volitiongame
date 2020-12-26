using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithCam : MonoBehaviour
{

//float distance = 5f;

//Vector3 thisObject = Transform.position; // getter
 // change 'NEW' Vector3
 public Transform newParent;

    // Start is called before the first frame update
    void Start()
    {
              transform.SetParent(newParent);
    }

   // public GameObject child;

    

/*

        // Same as above, except worldPositionStays set to false
        // makes the child keep its local orientation rather than
        // its global orientation.
        child.transform.SetParent(newParent, false);

        // Setting the parent to ‘null’ unparents the GameObject
        // and turns child into a top-level object in the hierarchy
        child.transform.SetParent(null);
*/



    // Update is called once per frame
    void Update()
    {
     //   thisObject.x = Camera.main.transform.position.x;
    //    thisObject.y = Camera.main.transform.position.y;
     //   Transform.position = thisObject;
    }
}
