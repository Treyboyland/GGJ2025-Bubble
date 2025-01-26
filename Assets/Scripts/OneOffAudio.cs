using System.Collections;
using UnityEngine;

public class OneOffAudio : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;

    public AudioSource AudioSource => audioSource;

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        if (gameObject.activeInHierarchy)
        {
            StartCoroutine(PlayWaitThenDisable());
        }
    }

    IEnumerator PlayWaitThenDisable()
    {
        audioSource.Play();
        while (audioSource.isPlaying)
        {
            yield return null;
        }

        gameObject.SetActive(false);
    }
}
