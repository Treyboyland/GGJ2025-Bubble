using rho;
using TMPro;
using UnityEngine;

public class EggTrackingTextUI : MonoBehaviour
{
    [SerializeField]
    TMP_Text textBox;

    [SerializeField]
    RuntimeGameObjectSet eggs;

    int hatched;

    int total;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        total = eggs.Count;
        UpdateText();
    }

    public void UpdateText()
    {
        string hatchedText = string.Format("{0:D2}", hatched);
        string totalText = string.Format("{0:D2}", total);
        textBox.text = $"Hatched: {hatchedText}/{totalText}";
    }

    public void IncrementHatched()
    {
        UpdateHatched(hatched + 1);
    }

    public void UpdateHatched(int numHatched)
    {
        hatched = numHatched;
        UpdateText();
    }

    public void UpdateTotalEggs(int numTotal)
    {
        total = numTotal;
    }
}
