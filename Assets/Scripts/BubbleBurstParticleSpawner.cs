using UnityEngine;

public class BubbleBurstParticleSpawner : MonoBehaviour
{
    [SerializeField]
    ParticlePool pool;

    public void SpawnParticle(BubbleBurstData burstData)
    {
        var particle = pool.GetObject();

        particle.transform.position = burstData.BurstLocation;
        particle.gameObject.SetActive(true);
    }
}
