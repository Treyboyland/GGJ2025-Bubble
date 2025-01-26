using UnityEngine;

public abstract class Powerup : MonoBehaviour
{
    [SerializeField]
    protected PowerupData associatedPowerup;

    protected float elapsedTime;

    bool isPowerupActive = false;

    public PowerupData AssociatedPowerup => associatedPowerup;

    // Update is called once per frame
    public virtual void Update()
    {
        if (isPowerupActive)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= associatedPowerup.SecondsForPowerup)
            {
                DeactivatePowerup();
            }
        }
    }

    public virtual void ActivatePowerup()
    {
        elapsedTime = 0; //Chained Powerups restart time
        isPowerupActive = true;
    }

    public virtual void DeactivatePowerup()
    {
        elapsedTime = 0;
        isPowerupActive = false;
    }
}
