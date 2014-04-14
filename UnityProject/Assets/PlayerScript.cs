using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    float movementSpeed = 5.0f;
    float verticalMoveAmount = 0.0f;
    float horizontalMoveAmount = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //verticalMoveAmount = Input.GetAxis("Vertical") * movementSpeed;
        //horizontalMoveAmount = Input.GetAxis("Horizontal") * movementSpeed;
        //verticalMoveAmount *= Time.deltaTime;
        //horizontalMoveAmount *= Time.deltaTime;
        //transform.Translate(horizontalMoveAmount, verticalMoveAmount, 0);
    }

    void FixedUpdate()
    {
        
        rigidbody2D.velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2D.AddForce(new Vector2(verticalMoveAmount, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidbody2D.AddForce(new Vector2(verticalMoveAmount, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.AddForce(new Vector2(0, horizontalMoveAmount));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.AddForce(new Vector2(0, horizontalMoveAmount));
        }
    }
}
