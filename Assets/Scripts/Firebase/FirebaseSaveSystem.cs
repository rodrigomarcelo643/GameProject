using Firebase.Firestore;
using System.Threading.Tasks;
using UnityEngine;

public static class FirebaseSaveSystem
{
    private static FirebaseFirestore db => FirebaseFirestore.DefaultInstance;

    public static async Task SaveScore(string userId, int score)
    {
        DocumentReference doc = db.Collection("scores").Document(userId);
        await doc.SetAsync(new
        {
            score = score,
            updatedAt = FieldValue.ServerTimestamp()
        });
        Debug.Log("Score saved for user: " + userId);
    }
}
