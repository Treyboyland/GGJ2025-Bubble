using UnityEngine;

public class LookTowardsMouse : MonoBehaviour
{
    [SerializeField]
    float SPRITE_CORRECTION_ANGLE = -90;

    // Update is called once per frame
    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z;
        var truePos = mousePos - transform.position;
        float angle = Mathf.Atan2(truePos.y, truePos.x) * Mathf.Rad2Deg + SPRITE_CORRECTION_ANGLE;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
