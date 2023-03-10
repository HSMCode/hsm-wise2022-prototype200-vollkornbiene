using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // need Input System from the Unity Registry -> Window -> Package Manager -> Packages: Unity Registry -> search for Input install search for Cinemachine and install too

public class PlayerController : MonoBehaviour
{

    private float moveSpeed = 1f;
    private float collisionOffset = 0.05f;
    private ContactFilter2D movementFilter;

    Vector2 movementInput;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb; 
    Animator animator;
    AudioSource audioSourceWalking;

    [SerializeField] AudioClip Footsteps;

    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    private bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D> ();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSourceWalking = GetComponent<AudioSource>();
    }

    private void FixedUpdate() // Checking if moving
    {
        if(canMove) 
        {
            // If movement input is not 0, try to move
            if (movementInput != Vector2.zero)
            {
                bool success = TryMove(movementInput);

                    if(!success) 
                    {
                        success = TryMove(new Vector2(movementInput.x, 0));
                    }

                    if(!success) 
                    {
                        success = TryMove(new Vector2(0, movementInput.y));
                    }
                
                animator.SetBool("IsMoving", success);
                audioSourceWalking.enabled = true;

            }

            else 
            {
                animator.SetBool("IsMoving", false);
                audioSourceWalking.enabled = false;
            }

            // Set direction of sprite to movement direction
            if(movementInput.x < 0) 
            {
                spriteRenderer.flipX = true;
            } 

            else if (movementInput.x > 0) 
            {
                spriteRenderer.flipX = false;
            }
        }

}

    private bool TryMove(Vector2 direction) 
    {
        if(direction != Vector2.zero) 
        {
            // Check for potential collisions
            int count = rb.Cast(
                direction, // X and Y values between -1 and 1 that represent the direction from the body to look for collisions
                movementFilter, // The settings that determine where a collision can occur on such as layers to collide with
                castCollisions, // List of collisions to store the found collisions into after the Cast is finished
                moveSpeed * Time.fixedDeltaTime + collisionOffset); // The amount to cast equal to the movement plus an offset

            if(count == 0)
            {
                rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
                return true;
            } 
            
            else 
            {
                return false;
            }
        } 
        else 
        {
            // Can't move if there's no direction to move in
            return false;
        }
    }

    void OnMove(InputValue movementValue) 
    {
        movementInput = movementValue.Get<Vector2>();
    }

    public void LockMovement()
    {
        canMove = false;
        audioSourceWalking.enabled = false;
    }

    public void UnlockMovement()
    {
        canMove = true;
    }
}