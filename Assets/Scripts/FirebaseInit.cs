using UnityEngine;
using Firebase;
using Firebase.Analytics;
using Firebase.Unity.Editor;

public class FirebaseInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
        });
    }

    private void Start()
    {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://voter-41176.firebaseio.com/");
    }
}
