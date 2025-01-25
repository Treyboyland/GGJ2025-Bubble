using UnityEngine;

[CreateAssetMenu(fileName = "ArrowStats", menuName = "Scriptable Objects/ArrowStats")]
public class ArrowStats : ScriptableObject
{
    [SerializeField]
    int damage;

    [SerializeField]
    bool piercing;

    public int Damage => damage;

    public bool Piercing => piercing;
}
