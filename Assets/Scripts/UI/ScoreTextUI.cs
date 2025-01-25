using rho;
using TMPro;
using UnityEngine;

public class ScoreTextUI : MonoBehaviour
{
    [SerializeField]
    TMP_Text textBox;

    [SerializeField]
    RuntimeInt scoreValue;

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
        textBox.text = "Points: " + string.Format("{0:D4}", scoreValue.Value);
    }
}
