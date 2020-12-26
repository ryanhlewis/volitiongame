using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class orbitLoadPlanet : MonoBehaviour
{
    // Start is called before the first frame update



 private void Start(){
     StartCoroutine(WaitAndLoad(3f, "Earth"));
 }


 
 private IEnumerator WaitAndLoad(float value, string scene) {
     yield return new WaitForSeconds(value);
     SceneManager.LoadScene(scene);
 }

}
