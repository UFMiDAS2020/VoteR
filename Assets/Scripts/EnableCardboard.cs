using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCardboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName("cardboard");
        UnityEngine.XR.XRSettings.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
