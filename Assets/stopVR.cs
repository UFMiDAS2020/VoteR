using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;

public class stopVR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {

        Screen.orientation = ScreenOrientation.AutoRotation;

        XRSettings.enabled = false;

    }

    
}
