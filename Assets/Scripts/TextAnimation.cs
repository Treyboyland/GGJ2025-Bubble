using TMPro;
using UnityEngine;

public class TextAnimation : MonoBehaviour
{
    [SerializeField]
    TMP_Text textBox;

    public string Text { get => textBox.text; set => textBox.text = value; }
}
