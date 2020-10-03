using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Firebase;
using Firebase.Auth;

namespace VoteR {
    public class SignUp : MonoBehaviour
    {
        
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        public TMP_Text emailText, passText, verifyText;
        public UnityEngine.UI.Button signUpButton;
        string email, password, verify;

  /*      void InitializeFirebase()
        {
            auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
            auth.StateChanged += AuthStateChanged;
            //AuthStateChanged(this, null);
        }*/

        public void Start()
        {
            email = emailText.text;
            password = passText.text;
            verify = verifyText.text;
        }

        public void OnButtonPress()
        {
            email = emailText.text;
            password = passText.text;
            verify = verifyText.text;
            if (email.Length != 0 && password.Equals(verify))
            {
                // Sign up stuff here
                auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
                    if (task.IsCanceled)
                    {
                        Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                        return;
                    }
                    if (task.IsFaulted)
                    {
                        Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                        return;
                    }

                    // Firebase user has been created.
                    Firebase.Auth.FirebaseUser newUser = task.Result;
                    Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                        newUser.DisplayName, newUser.UserId);
                });
            }
        }
    }
}
