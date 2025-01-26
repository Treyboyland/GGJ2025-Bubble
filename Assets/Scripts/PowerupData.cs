using UnityEngine;

[CreateAssetMenu(fileName = "PowerupData", menuName = "Scriptable Objects/PowerupData")]
public class PowerupData : ScriptableObject
{
    [SerializeField]
    string powerupName;

    [SerializeField]
    string powerUpTextAbbreviation;

    [SerializeField]
    float secondsForPowerup;

    public string PowerupName { get => powerupName; }
    public string PowerUpTextAbbreviation { get => powerUpTextAbbreviation; }
    public float SecondsForPowerup { get => secondsForPowerup; }
}
