using UnityEngine;

public class PowerupRapidFire : Powerup
{
    PlayerControl playerControl;

    [SerializeField]
    float rapidFireMultiplier;

    float initialCooldownValue;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        playerControl = FindFirstObjectByType<PlayerControl>();
        if (playerControl != null)
        {
            initialCooldownValue = playerControl.cooldownTimeSec;
        }
    }

    public override void ActivatePowerup()
    {
        base.ActivatePowerup();
        if (playerControl != null)
        {
            playerControl.cooldownTimeSec = initialCooldownValue / rapidFireMultiplier;
        }
    }

    public override void DeactivatePowerup()
    {
        base.DeactivatePowerup();
        if (playerControl != null)
        {
            playerControl.cooldownTimeSec = initialCooldownValue;
        }
    }
}
