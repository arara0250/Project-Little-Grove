using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;   // Stat 시스템 구현 전까지는 Inspector 에서 직접 설정
    private Vector2 moveInput;

    private Rigidbody2D _rb;
    private Animator _anim;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    // 물리연산 (ex.Rigidbody) 은 FixedUpdate() 권장
    void FixedUpdate()
    {
        _rb.velocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        _anim.SetBool("IsWalking", true);

        if (context.canceled) 
        { 
            _anim.SetBool("IsWalking", false);
            _anim.SetFloat("LastInputX", moveInput.x);
            _anim.SetFloat("LastInputY", moveInput.y);
        }
        
        moveInput = context.ReadValue<Vector2>();

        _anim.SetFloat("InputX", moveInput.x);
        _anim.SetFloat("InputY", moveInput.y);
    }
}
