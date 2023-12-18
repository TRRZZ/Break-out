using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantDownwardForce : MonoBehaviour
{
    public float downwardForce = 1500f; // Adjust this value to control the force applied.
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject.
        rb = GetComponent<Rigidbody2D>();
        // Apply a constant downward force in FixedUpdate.
        rb.velocity = new Vector2(0f,-downwardForce);

    }

    void Update()
    {

        if (transform.position.y < -4)
        {
            transform.position = new Vector2(0, -2);
        }

    }
}
