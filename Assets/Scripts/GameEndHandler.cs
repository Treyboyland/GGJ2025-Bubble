using rho;
using TMPro;
using UnityEngine;

public class GameEndHandler : MonoBehaviour
{
    [SerializeField]
    GameObject gameOverScreen;

    [SerializeField]
    TMP_Text victoryText;

    [SerializeField]
    TMP_Text scoreText;

    [SerializeField]
    RuntimeInt scoreValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoGameOver()
    {
        DoGameOver(false);
    }

    public void DoGameOver(bool winning)
    {
        gameOverScreen.SetActive(true);
        victoryText.text = winning ? "You Win!" : "You Lose!";
        scoreText.text = $"Score: {scoreValue.Value}";
    }
}
