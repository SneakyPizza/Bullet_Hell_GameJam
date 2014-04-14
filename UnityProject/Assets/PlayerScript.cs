using UnityEngine;
using System.Collections;
using System;

public class PlayerScript : MonoBehaviour
{
    float movementSpeed = 5000.0f;//TODO: figure out better value.
    public float movementMultiplier = 100.0f;
    float verticalMoveAmount = 0.0f;
    float horizontalMoveAmount = 0.0f;

    // Update is called once per frame
    void Update()
    {
        verticalMoveAmount = Input.GetAxis("Vertical") * movementSpeed * movementMultiplier;
        horizontalMoveAmount = Input.GetAxis("Horizontal") * movementSpeed * movementMultiplier;
    }

    void FixedUpdate()
    {
        
        rigidbody2D.velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2D.AddForce(new Vector2(0, verticalMoveAmount));
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody2D.AddForce(new Vector2(0, verticalMoveAmount));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.AddForce(new Vector2(horizontalMoveAmount, 0));
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.AddForce(new Vector2(horizontalMoveAmount, 0));
        }
    }
}
