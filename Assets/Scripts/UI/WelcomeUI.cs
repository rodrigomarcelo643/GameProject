using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WelcomeUI : MonoBehaviour
{
    public TMP_InputField nameInput;
    public Button continueButton;

    private void Start()
    {
        continueButton.onClick.AddListener(OnContinue);
    }

    private void OnContinue()
    {
        string name = nameInput.text.Trim();
        if (string.IsNullOrEmpty(name))
            name = "Guest";

        GameManager.Instance.currentPlayerName = name;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
    }
}
