using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    private Rigidbody2D rb2d;
    private Vector2 moveInput;

    private Animator animator;

    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    //update

    public void Update()
    {

        rb2d.linearVelocity = moveInput * moveSpeed;

    }
    public void Move(InputAction.CallbackContext context)
    {
        animator.SetBool("isMoving", true);

        if (context.canceled)
        {
            animator.SetBool("isMoving", false);
            animator.SetFloat("LastInputX", moveInput.x);
            animator.SetFloat("LastInputY", moveInput.y);
        }
        moveInput = context.ReadValue<Vector2>();
        animator.SetFloat("CurrentInputX", moveInput.x);
        animator.SetFloat("CurrentInputY", moveInput.y);

    }



}
