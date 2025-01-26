using UnityEngine;

public class PowerupMultishot : Powerup
{
    PlayerControl playerControl;

    [SerializeField]
    int shotMultiplier;

    int initialShotValue = 1;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        playerControl = FindFirstObjectByType<PlayerControl>();
        if (playerControl != null)
        {
            initialShotValue = playerControl.numProjectilesToShoot;
        }
    }

    public override void ActivatePowerup()
    {
        base.ActivatePowerup();
        if (playerControl != null)
        {
            playerControl.numProjectilesToShoot = initialShotValue * shotMultiplier;
        }
    }

    public override void DeactivatePowerup()
    {
        base.DeactivatePowerup();
        if (playerControl != null)
        {
            playerControl.numProjectilesToShoot = initialShotValue;
        }
    }
}
