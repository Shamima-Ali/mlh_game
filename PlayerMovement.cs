using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float motionSpeed;
    public Rigidbody2D rb;
    float max;
    public float jumpforce = 20f;
    public Transform feet;
    public LayerMask groundLayers;

    public Animator anim;
    
    // Update is called once per frame
    private void Update()
    {
      max = Input.GetAxisRaw("Horizontal");
      if (Input.GetButtonDown ("Jump") && IsGrounded())
      {
          Jump();
      }

      if (Mathf.Abs(max) > 0.05f)
      {
          anim.SetBool("isRunning", true);
      }
      else
      {
          anim.SetBool("isRunning", false);
      }

      anim.SetBool("isGrounded", IsGrounded());
    }

    private void FixedUpdate() 
    {
        Vector2 movement = new Vector2 (max*motionSpeed, rb.velocity.y);
        rb.velocity = movement;

        
    }

    private void Jump()
    {
        Vector2 movementV = new Vector2 (rb.velocity.x, jumpforce);
        rb.velocity = movementV;

    } 

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }
        else {
            return false;
        }
    }
    

}
