using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    T prefab;

    List<T> pool = new List<T>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    T CreateObject()
    {
        var newObject = Instantiate(prefab, transform);
        newObject.gameObject.SetActive(false);
        pool.Add(newObject);
        return newObject;
    }

    public void DisableAll()
    {
        foreach (var obj in pool)
        {
            obj.gameObject.SetActive(false);
        }
    }

    public bool AreAnyActive()
    {
        return pool.Where(x => x.gameObject.activeInHierarchy).Count() > 0;
    }
}
