using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonhandler : MonoBehaviour
{
    public GameObject notactive1;
    public GameObject notactive2;
    public GameObject notactive3;
    public GameObject active;

    public void ButtonHandler()
    {
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
