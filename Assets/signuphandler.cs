using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using Firebase.Auth;
using UnityEngine.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;

/*namespace Voter {

    public class User
    {
        public string uid;
        public string firstname;
        public string lastname;
        public string email;
        public int picid;

        public User(string _uid, string _firstname, string _lastname, string _email)
        {
            uid = _uid;
            firstname = _firstname;
            lastname = _lastname;
            email = _email;
        }
    }
    */
    public class signuphandler : MonoBehaviour
    {
        public TMP_Text firstNameText, lastNameText, emailText, passText, verifyText, debugText;
        // public UnityEngine.UI.Button signUpButton;
        string firstname, lastname, email, password, verify;
        Firebase.Auth.FirebaseAuth auth;

      //  DatabaseReference reference;

        // Start is called before the first frame update
        void Start()
        {
            auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
            // Set up the Editor before calling into the realtime database.
            //FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://voter-41176.firebaseio.com/");

            // Get the root reference location of the database.
            //reference = FirebaseDatabase.DefaultInstance.RootReference;
        }

        public void ButtonPress()
        {

            debugText.text = "Button Clicked";
            firstname = firstNameText.text;
            lastname = lastNameText.text;
            email = emailText.text;
            password = passText.text;
            verify = verifyText.text;
            
            // Sign up stuff here
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

                //User user = new User(newUser.UserId, firstname, lastname, email);
                //string json = JsonUtility.ToJson(user);

                //reference.Child("users").Child(newUser.UserId).SetRawJsonValueAsync(name);
                
                Debug.LogFormat("Firebase user created successfully: {0} ({1})", newUser.Email, newUser.UserId);
                // debugText.text = $"Firebase user created successfully: {newUser.DisplayName} ({newUser.UserId})"
            });
            SceneManager.LoadScene("Menu");

        }
    }

