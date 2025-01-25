using UnityEngine;

public class PauseControl : MonoBehaviour
{
    [SerializeField]
    GameObject pauseObject;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        ResumeGame();
    }

    public void TogglePause()
    {
        if (pauseObject.activeInHierarchy)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        pauseObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        pauseObject.SetActive(false);
        Time.timeScale = 1;
    }
}
