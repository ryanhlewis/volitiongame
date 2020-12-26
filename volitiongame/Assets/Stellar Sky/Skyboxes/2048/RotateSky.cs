using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{


public float RotateSpeed = 0.001f;

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat ("_Rotation", Time.time * RotateSpeed * 0.08f);
    }
}
