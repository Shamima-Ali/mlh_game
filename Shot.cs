using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float bulletSpeed = 15f;
    public float bulletDamage = 10f;
    public Rigidbody2D rb;

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = Vector2.right * bulletSpeed;

    }

    private void OnCollisionEnter2D (Collision2D collision )
    {
        Destroy(gameObject);
    }
}
