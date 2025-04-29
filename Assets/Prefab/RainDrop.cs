using UnityEngine;

public class RainDrop : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            GameManager.instance.MissCount++;

            Destroy(gameObject);
        }
    }
}
