using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    public Image imgGaze;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfRay = 10;
    private RaycastHit hit;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

         Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out hit, distanceOfRay))
        {
            if (imgGaze.fillAmount == 1 && hit.transform.CompareTag("SceneLoader"))
            {
                Debug.Log("Gaze Working");

               // Application.LoadLevel("Menu");
            }
        } 
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }
}
