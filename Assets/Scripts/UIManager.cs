using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    
    [SerializeField] private TMP_Text scoreText;
    private UIManager uIManager;

    private void Awake()
    {
        
    }

    public void UpdateScoreUI(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
