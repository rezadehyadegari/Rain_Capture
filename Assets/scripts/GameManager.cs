using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public int MissCount = 0;
    public TextMeshProUGUI scoreText;

    private bool gameOver = false;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (gameOver) return;

        scoreText.text = "Score: " + score + "\nMissed: " + MissCount;

        if (MissCount >= 3)
        {
            score--;
            MissCount = 0;
        }

        if (score >= 10)
        {
            gameOver = true;
            scoreText.text = "🎉 You Win!";
            Time.timeScale = 0f;
        }

        if (score < 0)
        {
            gameOver = true;
            scoreText.text = "💀 Game Over";
            Time.timeScale = 0f;
        }
    }
}