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

    public int Health => health;

    public float Speed => useRandom ? randomizedSpeed.Random() : speed;
}
