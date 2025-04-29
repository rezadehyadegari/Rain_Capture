using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public int MissCount = 0;

    public Text scoreText;

    void Awake()
    {

        instance = this;
    }

    void Update()
    {
        scoreText.text = "Score: " + score + "\nMissed: " + MissCount;

        if (MissCount >= 2)
        {
            score--;
            MissCount = 0;
        }
    }
}
