using UnityEngine;

public class PowerupDoubleScore : Powerup
{
    ScoreHandler handler;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        handler = FindFirstObjectByType<ScoreHandler>();
    }

    public override void ActivatePowerup()
    {
        base.ActivatePowerup();
        if (handler != null)
        {
            handler.ScoreMultiplier = 2;
        }
    }

    public override void DeactivatePowerup()
    {
        base.DeactivatePowerup();
        if (handler != null)
        {
            handler.ScoreMultiplier = 1;
        }
    }
}
