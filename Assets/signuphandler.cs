using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Firebase.Auth;
using UnityEngine.SceneManagement;

public class signuphandler : MonoBehaviour
{
    public TMP_Text emailText, passText, verifyText, debugText;
   // public UnityEngine.UI.Button signUpButton;
    string email, password, verify;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ButtonPress()
    {
        debugText.text = "Button Clicked";
        email = emailText.text;
        Debug.Log("This is the email" + email);
        password = passText.text;
        verify = verifyText.text;
        // Sign up stuff here
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
                    if (task.IsCanceled)
                    {
                        Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                        debugText.text = "CreateUserWithEmailAndPasswordAsync was canceled.";
                        return;
                    }
                    if (task.IsFaulted)
                    {
                        Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                        debugText.text = "CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception;
                        return;
                    }

                    // Firebase user has been created.
                    Firebase.Auth.FirebaseUser newUser = task.Result;
                    Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                        newUser.DisplayName, newUser.UserId);
                    debugText.text = $"Firebase user created successfully: {newUser.DisplayName} ({newUser.UserId})";
                });
        SceneManager.LoadScene("Menu");

    }
}
