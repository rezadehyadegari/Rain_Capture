using UnityEngine;

public class RainSpawnerScript : MonoBehaviour
{
    public GameObject rainDropPrefab;
    public float spawnRate = 0.5f; // هر نیم ثانیه یک بار قطره بسازه
    public float spawnRangeX = 8f; // محدوده پخش قطره ها در عرض
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnRainDrop();
            timer = 0f;
        }
    }

    void SpawnRainDrop()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);
        Instantiate(rainDropPrefab, spawnPosition, Quaternion.identity);
    }
}
