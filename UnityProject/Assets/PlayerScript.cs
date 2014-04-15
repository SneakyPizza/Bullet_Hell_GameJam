using UnityEngine;
using System.Collections;
using System;

public class PlayerScript : MonoBehaviour
{
    float movementSpeed = 5000.0f;//TODO: figure out better value.
    public float movementMultiplier = 100.0f;
    float verticalMoveAmount = 0.0f;
    float horizontalMoveAmount = 0.0f;
	float playerHealth = 3.0f;

    // Update is called once per frame
    void Update()
    {
        verticalMoveAmount = Input.GetAxis("Vertical") * movementSpeed * movementMultiplier;
        horizontalMoveAmount = Input.GetAxis("Horizontal") * movementSpeed * movementMultiplier;


		if(Input.GetKey(KeyCode.Alpha1) && playerHealth < 3)//pickup health
		{
			playerHealth++;
		}
		if(Input.GetKey(KeyCode.Alpha2) && playerHealth > 0)//take damage
		{
			playerHealth--;
		}
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
	void OnGUI() 
	{
		string result = GUI.TextField(new Rect(10.0f, 10.0f, 50.0f, 25.0f), playerHealth.ToString());
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("ik zie de trigger");
	}
}
