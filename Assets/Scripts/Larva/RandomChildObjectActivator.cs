using System.Linq;
using UnityEngine;

public class RandomChildObjectActivator : MonoBehaviour
{
    public void ActivateRandomChildObject()
    {
        var disabledChildren = GetComponentsInChildren<Transform>(includeInactive:true)
            .Select(t => t.gameObject)
            .Where(go => go != null && !go.activeSelf)
            .OrderBy(go => Random.value);
        
        if (disabledChildren.Count() > 0)
        {
            disabledChildren.First().SetActive(true);
        }
    }
}
