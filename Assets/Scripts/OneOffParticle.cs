using System.Collections;
using UnityEngine;

public class OneOffParticle : MonoBehaviour
{
    [SerializeField]
    ParticleSystem particle;

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    private void OnEnable()
    {
        if (gameObject.activeInHierarchy)
        {
            StartCoroutine(PlayWaitThenDisable());
        }
    }

    IEnumerator PlayWaitThenDisable()
    {
        particle.Play();

        while (particle.isPlaying || particle.particleCount > 0)
        {
            yield return null;
        }

        gameObject.SetActive(false);
    }
}
