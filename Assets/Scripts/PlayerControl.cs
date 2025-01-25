using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    Camera mainCamera;

    [SerializeField]
    Player player;

    [SerializeField]
    ArrowPool arrowPool;

    [SerializeField]
    float arrowSpeed;

    const float SPRITE_CORRECTION_ANGLE = -90;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void HandleMovement(InputAction.CallbackContext context)
    {

    }

    public void HandleFire(InputAction.CallbackContext context)
    {
        //Debug.LogWarning("Fire");
        if (context.started)
        {
            var arrow = arrowPool.GetObject();
            var mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = player.transform.position.z;
            var truePos = mousePos - player.transform.position;
            float angle = Mathf.Atan2(truePos.y, truePos.x) * Mathf.Rad2Deg + SPRITE_CORRECTION_ANGLE;
            arrow.SetSpeed(angle, arrowSpeed);
            arrow.transform.position = player.transform.position;
            arrow.gameObject.SetActive(true);
        }
    }

    public void HandleMouseMovement(InputAction.CallbackContext context)
    {

    }
}
