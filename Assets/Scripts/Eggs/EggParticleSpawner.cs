using UnityEngine;

public class EggParticleSpawner : MonoBehaviour
{
    [SerializeField]
    ParticlePool pool;

    public void SpawnParticle(Vector2 position)
    {
        var particle = pool.GetObject();

        particle.transform.position = position;
        particle.gameObject.SetActive(true);
    }
}
