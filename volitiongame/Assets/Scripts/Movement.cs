using UnityEngine;
using System.Collections;
 
public class Movement : MonoBehaviour {
 
 
    //===Panning===
    float mouseX;
    float mouseY;
    float sensitivity;
    Vector3 cameraPos;


    void Start () {

 
        //===Panning===
 
        sensitivity = 0.05f;
        cameraPos = transform.position;
 
 
    }
   
 
    void Update () {

            Panning ();

    }
 
 
    public void Panning(){
        
            mouseX = Input.GetAxis ("Mouse X");
            mouseY = Input.GetAxis ("Mouse Y");

            if(mouseY < Screen.width) {
           cameraPos += transform.right * (mouseX * 1) * sensitivity;
            }

           if(mouseX < Screen.width) {
           cameraPos += transform.up * (mouseY * 1) * sensitivity;
           }

           transform.position = cameraPos;

            
        
    }

}
