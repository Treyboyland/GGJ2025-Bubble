using UnityEngine;

public class GameObjectSpawner : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] Transform location;

    public void Spawn()
    {
        Instantiate(original:target, position: location.position, rotation: location.rotation);
    }

    public void SpawnAtPosition(Vector2 position)
    {
        Instantiate(original:target, position: position, rotation: Quaternion.identity);
    }
}
