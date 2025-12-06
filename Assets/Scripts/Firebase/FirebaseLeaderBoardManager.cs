using Firebase.Firestore;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public static class FirebaseLeaderboardManager
{
    private static FirebaseFirestore db => FirebaseFirestore.DefaultInstance;

    public static async Task<List<(string user, int score)>> GetTopScores(int limit = 10)
    {
        List<(string user, int score)> leaderboard = new List<(string user, int score)>();

        QuerySnapshot snapshot = await db.Collection("scores")
            .OrderByDescending("score")
            .Limit(limit)
            .GetSnapshotAsync();

        foreach (DocumentSnapshot doc in snapshot.Documents)
        {
            int score = doc.GetValue<int>("score");
            leaderboard.Add((doc.Id, score));
        }

        return leaderboard;
    }
}
