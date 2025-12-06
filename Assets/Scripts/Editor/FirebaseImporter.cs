using UnityEditor;
using UnityEngine;

public class FirebaseImporter
{
    [MenuItem("Tools/Import Firebase SDK")]
    public static void ImportFirebaseSDK()
    {
        string[] packages = {
            "Assets/FirebaseSDK/FirebaseAuth.unitypackage",
            "Assets/FirebaseSDK/FirebaseFirestore.unitypackage",
            "Assets/FirebaseSDK/FirebaseDatabase.unitypackage",
            "Assets/FirebaseSDK/FirebaseAnalytics.unitypackage"
        };

        foreach (string pkg in packages)
        {
            if (System.IO.File.Exists(pkg))
            {
                AssetDatabase.ImportPackage(pkg, true);
                Debug.Log("Imported: " + pkg);
            }
            else
            {
                Debug.LogWarning("Package not found: " + pkg);
            }
        }
    }
}
