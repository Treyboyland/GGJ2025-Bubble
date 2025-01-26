using System.Collections;
using UnityEngine;

public class DisableAfterAnimation : MonoBehaviour
{
    [SerializeField]
    Animator controller;

    [SerializeField]
    string finishedStateName;

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    private void OnEnable()
    {
        if (gameObject.activeInHierarchy)
        {
            StartCoroutine(WaitThenDisable());
        }
    }

    IEnumerator WaitThenDisable()
    {
        while (!controller.GetCurrentAnimatorStateInfo(0).IsName(finishedStateName))
        {
            yield return null;
        }

        gameObject.SetActive(false);
    }
}
