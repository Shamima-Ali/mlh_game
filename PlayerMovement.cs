using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float motionSpeed;
    public Rigidbody2D rb;
    float max;
    public float jumpforce = 20f;
    
    // Update is called once per frame
    void Update()
    {
      max = Input.GetAxisRaw("Horizontal");
      if (Input.GetButtonDown ("Jump"))
      {
          Jump();
      }
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

}
