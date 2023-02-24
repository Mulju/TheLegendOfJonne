using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class holds the functionality for the players movements.
 */

public class PlayerMovement : MonoBehaviour
{
    // Fetching the gameobjects the player is using.
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    // Modifiable 
    [SerializeField] private LayerMask jumpableGround;

    private float dirX = 0f;

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    private bool canDoubleJump;

    private enum MovementState { idle, running, jumping, falling }

    [SerializeField] private AudioSource pelimusahyppy;

    private void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();        
    }

    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        /* Double jump functionality. Checks if player is grounded from IsGrounded() method,
           then after first jump changes boolean to false to prevent more than 2 jumps. */
        if (IsGrounded())
        {
            canDoubleJump = true;
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (IsGrounded())
            {
                pelimusahyppy.Play();
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                canDoubleJump = true;
            }
            else if (canDoubleJump)
            {
                pelimusahyppy.Play();
                rb.velocity = new Vector2(rb.velocity.x, jumpForce * .84f);
                canDoubleJump = false;
            }            
        }
        UpdateAnimationState();
    }

    // Updates Player animation depending on movement state.
    private void UpdateAnimationState()
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }
        if (rb.velocity.y > .1f) 
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }
        anim.SetInteger("state", (int)state);
    }

    // Casts a Box under the player Boxcollider to check if player is grounded.
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, new Vector2(coll.bounds.size.x - .2f, coll.bounds.size.y / 2), 0f, Vector2.down, coll.bounds.size.y / 2, jumpableGround);
    } 
}