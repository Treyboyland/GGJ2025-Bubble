using UnityEngine;

public class Shake : MonoBehaviour
{
    bool canShake = false;
    float curStrength = 0.0f;
    float curDuration = 0.0f;
    Vector3 initialPosition = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (curDuration <= 0.0f)
        {
            canShake = false;
            transform.position = initialPosition;
        }

        if (canShake)
        {
            transform.position += (Random.insideUnitSphere * curStrength);
            curDuration -= Time.deltaTime;
            curDuration = Mathf.Max(curDuration, 0.0f);
        }
    }

    public void DoShake(float strength)
    {
        if (!canShake)
        {
            initialPosition = transform.position;
        }
        canShake = true;
        curStrength = strength;
        curDuration = 0.35f;
    }
}
