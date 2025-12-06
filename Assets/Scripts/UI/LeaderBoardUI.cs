using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeaderboardUI : MonoBehaviour
{
    public Transform contentArea;
    public GameObject scoreRowPrefab;

    private async void Start()
    {
        List<(string user, int score)> leaderboard = await FirebaseLeaderboardManager.GetTopScores();

        foreach (var entry in leaderboard)
        {
            GameObject row = Instantiate(scoreRowPrefab, contentArea);
            row.transform.Find("NameText").GetComponent<TMP_Text>().text = entry.user;
            row.transform.Find("ScoreText").GetComponent<TMP_Text>().text = entry.score.ToString();
        }
    }
}
