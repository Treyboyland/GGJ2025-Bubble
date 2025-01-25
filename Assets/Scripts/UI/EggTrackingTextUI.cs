using TMPro;
using UnityEngine;

public class EggTrackingTextUI : MonoBehaviour
{
    [SerializeField]
    TMP_Text textBox;

    int hatched;

    int total;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        string hatchedText = string.Format("{0:D2}", hatched);
        string totalText = string.Format("{0:D2}", total);
        textBox.text = $"Hatched: {hatchedText}/{totalText}";
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
