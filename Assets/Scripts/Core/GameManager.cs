using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public string currentPlayerName = "Guest";
    public int currentScore = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ResetScore()
    {
        currentScore = 0;
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
        Debug.Log("Current Score: " + currentScore);
    }
}
