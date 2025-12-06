using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public void AddPoint(int amount = 1)
    {
        GameManager.Instance.AddScore(amount);
    }

    public async void SaveScore()
    {
        string userId = FirebaseAuthManager.Instance.user.UserId;
        int score = GameManager.Instance.currentScore;
        await FirebaseSaveSystem.SaveScore(userId, score);
    }
}
