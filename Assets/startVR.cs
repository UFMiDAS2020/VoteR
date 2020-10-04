using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class startVR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {

        Screen.orientation = ScreenOrientation.LandscapeLeft;

        StartCoroutine(LoadDevice("cardboard"));

        XRSettings.enabled = true;

    }



    IEnumerator LoadDevice(string newDevice)

    {

        XRSettings.LoadDeviceByName(newDevice);

        yield return null;

        Screen.orientation = ScreenOrientation.LandscapeLeft;

        XRSettings.enabled = true;

    }
}
