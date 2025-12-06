using UnityEngine;
using Firebase;
using Firebase.Extensions;

public class FirebaseInitializer : MonoBehaviour
{
    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync()
        .ContinueWithOnMainThread(task =>
        {
            var status = task.Result;

            if (status == DependencyStatus.Available)
            {
                FirebaseApp.Create(new AppOptions()
                {
                    ApiKey = EnvConfig.Get("FIREBASE_API_KEY"),
                    ProjectId = EnvConfig.Get("FIREBASE_PROJECT_ID"),
                    AppId = EnvConfig.Get("FIREBASE_APP_ID")
                });

                Debug.Log("Firebase initialized successfully.");
            }
            else
            {
                Debug.LogError("Firebase dependencies are not available: " + status);
            }
        });
    }
}
