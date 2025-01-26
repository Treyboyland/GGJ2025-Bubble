using UnityEngine;

public class EggNotificationHandler : MonoBehaviour
{
    [SerializeField]
    TextAnimationPool pool;

    [SerializeField]
    string hatchedText;

    [SerializeField]
    string destroyedText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowHatchedText(Vector2 position)
    {
        var text = pool.GetObject();
        text.Text = hatchedText;

        text.transform.position = position;
        text.gameObject.SetActive(true);
    }

    public void ShowDestroyedText(Vector2 position)
    {
        var text = pool.GetObject();
        text.Text = destroyedText;

        text.transform.position = position;
        text.gameObject.SetActive(true);
    }
}
