using UnityEngine;
using UnityEngine.UI; 

public class PlayerScoreScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
