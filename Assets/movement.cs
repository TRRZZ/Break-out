using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    Rigidbody2D myRigidBody;


    void Start()
    {

        myRigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {

            myRigidBody.AddForce(new Vector2(50, 0));

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            myRigidBody.AddForce(new Vector2(-50, 0));

        }

    }
}
