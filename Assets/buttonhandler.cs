using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonhandler : MonoBehaviour
{
    /*public GameObject Panelhome;
    public GameObject Paneltraining;
    public GameObject Panelbadge;
    public GameObject Panelsetting;*/
    public GameObject notactive1;
    public GameObject notactive2;
    public GameObject notactive3;
    public GameObject active;
   





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonHandler()
    {
        /*Panelhome.SetActive(true);
        Panelbadge.SetActive(false);
        Paneltraining.SetActive(false);
        Panelsetting.SetActive(false);*/

        notactive1.SetActive(false);
        notactive2.SetActive(false);
        notactive2.SetActive(false);
        active.SetActive(true);

    }
    public void MovetoVrScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
