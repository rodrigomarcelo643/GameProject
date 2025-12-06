using UnityEngine;
using Firebase.Auth;
using Firebase.Extensions;

public class FirebaseAuthManager : MonoBehaviour
{
    public static FirebaseAuthManager Instance;
    public FirebaseAuth auth;
    public FirebaseUser user;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        auth = FirebaseAuth.DefaultInstance;
    }

    public void SignInAnonymously()
    {
        auth.SignInAnonymouslyAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsCompleted && !task.IsCanceled && !task.IsFaulted)
            {
                user = task.Result;
                Debug.Log("Logged in anonymously as: " + user.UserId);
            }
            else
            {
                Debug.LogError("Anonymous login failed.");
            }
        });
    }
}
