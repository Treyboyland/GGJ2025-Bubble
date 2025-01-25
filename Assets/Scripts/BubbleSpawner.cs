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

    // Eventually will set these to real values
    public int eggsRemain = 0;
    int diffIncSeq = 0;
    const int NUM_TIMES_BEFORE_SUB_NUMSPAWN = 6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnBubbles();
        UpdateSpawnTime();
        eggsRemain = GameObject.FindGameObjectsWithTag("egg").Length;
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
    
    public void DecreaseEggCount()
    {
        eggsRemain--;
        IncreaseDifficulty();
    }

    void IncreaseDifficulty()
    {
        diffIncSeq++;
        if (diffIncSeq % NUM_TIMES_BEFORE_SUB_NUMSPAWN == 0)
        {
            numberOfSpawns.y--;
            numberOfSpawns.y = Mathf.Max(numberOfSpawns.y, 1);
        }

        secondsBetweenSpawns = Vector2.Scale(secondsBetweenSpawns, new Vector2(0.88f, 0.88f));
    }
}
