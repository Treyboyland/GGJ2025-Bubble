using System.Linq;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] rho.RuntimeInt score;
    [SerializeField] rho.RuntimeGameObjectSet eggs;

    #region Event Handlers
    public void ModifyScore(int amount)
    {
        score.Value += amount;
    }
    #endregion
    
    void SetScoreToSumOfAllEggHealth()
    {
        score.Value = eggs.Select(e => e.GetComponent<EggHealth>())
            .Where(eh => eh != null)
            .Sum(eh => eh.Health);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SetScoreToSumOfAllEggHealth();
        score.Value = 0;
    }
}
