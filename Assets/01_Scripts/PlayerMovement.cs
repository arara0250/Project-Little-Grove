using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;   // Stat 시스템 구현 전까지는 Inspector 에서 직접 설정
    private Vector2 moveInput;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // 물리연산 (ex.Rigidbody) 은 FixedUpdate() 권장
    void FixedUpdate()
    {
        _rb.velocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
