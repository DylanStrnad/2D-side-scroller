using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal");

        if (moveDirection > 0 && !facingRight)
        {
            FlipCharacter();   
            
        }
        else if (moveDirection < 0 && facingRight) 
        {
            FlipCharacter();
        }

        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
    }

    private void FlipCharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 100f, 0f);
    }
}
