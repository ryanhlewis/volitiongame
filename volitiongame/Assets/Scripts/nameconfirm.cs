using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class nameconfirm : MonoBehaviour
{
    // Start is called before the first frame update

public Animator transitionAnim;
public TMP_InputField InputFieldComponent;
    public TMP_Text m_TextComponent;
        public TMP_Text m_TextComponent1;
public Animator canvasAnim;
public GameObject canvas;

 private void Start(){

string name = "";

  m_TextComponent = GetComponent<TMP_Text>();


        InputFieldComponent.onSubmit.AddListener(OnSubmit);

    }

    void OnSubmit(string text)
    {
        if (text != "") {
            
    //    m_TextComponent.font = Resources.Load<TMP_FontAsset>("Fonts & Materials/LiberationSans SDF");
        name = text;
        m_TextComponent1.text=name;
        Debug.Log("OnSubmit event received." + "The new player name is " + name + "!");

canvasAnim = canvas.GetComponent<Animator>();

canvasAnim.Play("idleeeee");

//This is a weird bug. Sometimes it loads my Orbit scene- sometimes it doesn't. To be sure it does- I'm brute forcing it here in the name confirm script.

//So 10 seconds from the enter on the name, it will force the player to the Orbit scene.

StartCoroutine(ForceOrbit());


//if(canvasAnim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.99f) 
//canvasAnim.enabled = !canvasAnim.enabled;

        }
        //Debug.Log(InputFieldComponent.selectionAnchorPosition + "  " + InputFieldComponent.selectionFocusPosition);
    }

       IEnumerator ForceOrbit()
    {
        
        yield return new WaitForSeconds(10);


        SceneManager.LoadScene("Orbit");



    }


    }


 



