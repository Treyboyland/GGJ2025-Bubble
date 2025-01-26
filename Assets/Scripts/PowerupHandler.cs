using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PowerupHandler : MonoBehaviour
{
    [SerializeField]
    List<Powerup> powerups;

    public void ActivatePowerup(PowerupData powerupData)
    {
        var chosenPowerup = powerups.Where(x => x.AssociatedPowerup == powerupData).FirstOrDefault();

        if (chosenPowerup != default(Powerup))
        {
            chosenPowerup.ActivatePowerup();
        }
    }
}
