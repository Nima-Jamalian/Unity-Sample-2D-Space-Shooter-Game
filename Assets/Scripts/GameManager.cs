using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float worldSizeHeight;
    public static float worldSizeWidth;

    [SerializeField] private int score = 0;

    [SerializeField] UIManager uIManager;

    void Awake()
    {
        worldSizeHeight = Camera.main.orthographicSize;
        worldSizeWidth = Camera.main.orthographicSize * Camera.main.aspect;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void IncreaseScore()
    {
        score++;
        uIManager.UpdateScoreUI(score);
    }
}
