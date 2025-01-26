using UnityEngine;

public class PowerupPiercingShot : Powerup
{
    PlayerControl playerControl;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        playerControl = FindFirstObjectByType<PlayerControl>();
    }

    public override void ActivatePowerup()
    {
        base.ActivatePowerup();
        if (playerControl != null)
        {
            playerControl.UsePiercingArrows = true;
        }
    }

    public override void DeactivatePowerup()
    {
        base.DeactivatePowerup();
        if (playerControl != null)
        {
            playerControl.UsePiercingArrows = false;
        }
    }
}
