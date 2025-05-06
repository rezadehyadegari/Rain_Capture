using UnityEngine;

public class RainDrop : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            GameManager.instance.MissCount++;
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Player"))
        {
            GameManager.instance.score++;
            Destroy(gameObject);
        }
    }
}
