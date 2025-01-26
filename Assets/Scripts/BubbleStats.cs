using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BubbleStats", menuName = "Scriptable Objects/BubbleStats")]
public class BubbleStats : ScriptableObject
{
    [SerializeField]
    int health;

    [SerializeField]
    float speed;

    [SerializeField]
    Vector2 randomizedSpeed;

    [SerializeField]
    bool useRandom;

    [SerializeField]
    int score;

    [Range(0, 1)]
    [SerializeField]
    float powerupSpawningOdds;

    [SerializeField]
    List<PowerupData> potentialPowerups;

    public int Health => health;

    public float Speed => useRandom ? randomizedSpeed.Random() : speed;

    public int Score => score;

    public List<PowerupData> PotentialPowerups => potentialPowerups;

    public bool ShouldSpawnPowerup()
    {
        return Random.Range(0.0f, 1.0f) <= powerupSpawningOdds;
    }
}
