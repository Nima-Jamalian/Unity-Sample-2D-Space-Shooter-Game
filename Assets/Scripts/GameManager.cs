using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static float worldSizeHeight;
    public static float worldSizeWidth;
    private static int score = 0;
    [SerializeField] private UIManager uIManager;
    void Awake()
    {
        worldSizeHeight = Camera.main.orthographicSize;
        worldSizeWidth = Camera.main.orthographicSize * Camera.main.aspect;
    }

    public void IncreaseScore()
    {
        score++;
        uIManager.UpdateScoreUI(score);
    }

}
