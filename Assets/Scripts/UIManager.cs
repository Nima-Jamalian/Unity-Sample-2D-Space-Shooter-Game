using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    
    [SerializeField] private TMP_Text scoreText;

    public void UpdateScoreUI(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Game");
    }
}
