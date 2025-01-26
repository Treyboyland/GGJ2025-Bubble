using rho;
using UnityEngine;

public class GameEndChecker : MonoBehaviour
{
    [SerializeField]
    GameEventBool onGameEndedEvent;

    [SerializeField]
    RuntimeGameObjectSet eggs;

    [Range(0.0f, 1.0f)]
    [SerializeField]
    float destroyedEggsCutoffPercentage;

    int totalEggs;

    int hatchedEggs;

    int destroyedEggs;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        totalEggs = eggs.Count;
    }

    public void CheckForGameEnd()
    {
        bool endGame = hatchedEggs + destroyedEggs >= totalEggs;
        bool success = destroyedEggs <= (int)(totalEggs * destroyedEggsCutoffPercentage);

        if (endGame /*|| !success*/)
        {
            onGameEndedEvent.Invoke(success);
        }
    }

    public void IncrementHatched()
    {
        hatchedEggs++;
        CheckForGameEnd();
    }

    public void IncrementDestroyed()
    {
        destroyedEggs++;
        CheckForGameEnd();
    }
}
