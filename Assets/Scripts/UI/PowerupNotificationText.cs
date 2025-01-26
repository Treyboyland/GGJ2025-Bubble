using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PowerupNotificationText : MonoBehaviour
{
    [SerializeField]
    TMP_Text textBox;

    [SerializeField]
    float secondsBetweenPowerups;

    List<PowerupData> currentPowerups = new List<PowerupData>();

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        textBox.text = "";
    }

    public void AddPowerup(PowerupData powerup)
    {
        if (!currentPowerups.Contains(powerup))
        {
            currentPowerups.Add(powerup);
        }

        if (currentPowerups.Count > 0)
        {
            StopAllCoroutines();
            StartCoroutine(GoThroughPowerups());
        }
    }

    public void RemovePowerup(PowerupData powerup)
    {
        currentPowerups.Remove(powerup);

        if (currentPowerups.Count == 0)
        {
            StopAllCoroutines();
            textBox.text = "";
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(GoThroughPowerups());
        }
    }


    IEnumerator GoThroughPowerups()
    {
        while (true)
        {
            foreach (var powerup in currentPowerups)
            {
                textBox.text = powerup.PowerUpTextAbbreviation;
                yield return new WaitForSeconds(secondsBetweenPowerups);
            }
            yield return null;
        }
    }
}
