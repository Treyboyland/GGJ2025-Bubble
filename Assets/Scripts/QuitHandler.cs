using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class QuitHandler : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#elif !UNITY_WEBGL
        Application.Quit();
#else
        //Do nothing
#endif
    }
}
