using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float motionSpeed;
    public Rigidbody2D rb;
    float max;
    
    // Update is called once per frame
    void Update()
    {
      max = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate() 
    {
        Vector2 movement = new Vector2 (max*motionSpeed, rb.velocity.y);
        rb.velocity = movement;
    }

}
