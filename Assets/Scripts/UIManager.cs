using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private GameObject gameOverItems;
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Game");
    }

    public void UpdateScoreUI(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void DisplayGameOver()
    {
        gameOverItems.SetActive(true);
    }

    public void OnRestartButtonClicked()
    {
        SceneManager.LoadScene("Game");
    }
}
