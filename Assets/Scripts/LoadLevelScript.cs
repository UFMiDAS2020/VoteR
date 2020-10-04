using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevelScript : MonoBehaviour
{
    public string loadLevel;

	private void Start()
	{
        UnityEngine.XR.XRSettings.LoadDeviceByName("None");
        UnityEngine.XR.XRSettings.enabled = false;
        //StartCoroutine(LoadDevice("None"));
	}
	public void LoadTheLevel(){
        Application.LoadLevel(loadLevel);
    }

    public void TurnOnCardboard(){
        //UnityEngine.XR.XRSettings.LoadDeviceByName("Cardboard");
        UnityEngine.XR.XRSettings.enabled = true;
    }
    /*
    IEnumerator LoadDevice(string newDevice){
        UnityEngine.XR.XRSettings.loadedDeviceName(newDevice);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = true;
    }
    */
}
