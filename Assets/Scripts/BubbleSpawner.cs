using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    [SerializeField]
    Vector2 xPosition;

    [SerializeField]
    float yPosition;

    [SerializeField]
    Vector2 secondsBetweenSpawns;

    [SerializeField]
    Vector2Int numberOfSpawns;

    [SerializeField]
    BubblePool pool;

    float elapsed = 0;

    float spawnTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnBubbles();
        UpdateSpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed > spawnTime)
        {
            SpawnBubbles();
            UpdateSpawnTime();
        }
    }

    void UpdateSpawnTime()
    {
        elapsed = 0;
        spawnTime = secondsBetweenSpawns.Random();
    }

    void SpawnBubbles()
    {
        int numSpawned = numberOfSpawns.Random();

        for (int i = 0; i < numSpawned; i++)
        {
            var bubble = pool.GetObject();
            bubble.transform.position = new Vector3(xPosition.Random(), yPosition);
            bubble.gameObject.SetActive(true);
        }
    }
}
