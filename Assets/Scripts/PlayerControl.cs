using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public float cooldownTimeSec = 0.0f;
    float cooldownTimer = 0.0f;

    [SerializeField]
    Camera mainCamera;

    [SerializeField]
    Player player;

    [SerializeField]
    ArrowPool arrowPool;

    [SerializeField]
    float arrowSpeed;

    const float SPRITE_CORRECTION_ANGLE = -90;
    bool isAttacking = false;

    void Start()
    {

    }

    public void Update()
    {
        cooldownTimer -= Time.deltaTime;
        cooldownTimer = Mathf.Max(cooldownTimer, 0.0f);

        if (isAttacking && cooldownTimer <= 0.0f)
        {
            cooldownTimer = cooldownTimeSec;

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

    public void HandleMovement(InputAction.CallbackContext context)
    {

    }

    public void HandleFire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isAttacking = true;
        }

        if (context.canceled)
        {
            isAttacking = false;
        }
    }

    public void HandleMouseMovement(InputAction.CallbackContext context)
    {

    }
}
