using UnityEngine;
using System.Collections;
using System;

public class PlayerScript : MonoBehaviour
{
	float movementSpeed = 5000.0f;//TODO: figure out better value.
	public float movementMultiplier = 100.0f;
	float verticalMoveAmount = 0.0f;
	float horizontalMoveAmount = 0.0f;
	public float playerHealth = 3.0f;
	float cooldown = 0.0f;
	public float enemySpawn = 3.0f;
	float currentEnemyCooldown = 0.0f;
	
	float shootCooldown = 0.0f; //cooldown = 0.3ish
	public Transform BulletLocation1;
	public Transform BulletLocation2;
	public Transform BulletLocation3;
	public Transform playerbullet;
	public Transform Enemy;
	// Update is called once per frame
	void Update()
	{
		verticalMoveAmount = Input.GetAxis("Vertical") * movementSpeed * movementMultiplier;
		horizontalMoveAmount = Input.GetAxis("Horizontal") * movementSpeed * movementMultiplier;
		
		if (Input.GetKey(KeyCode.Space) && Time.time > shootCooldown)
		{
			//we are moving to the right so we use the right bullet spot
			if (Input.GetKey(KeyCode.D))
			{
				Instantiate(playerbullet, BulletLocation1.position, BulletLocation1.rotation);
				shootCooldown = Time.time + 0.3f;
			}
			//we are moving to the left so we use the left bullet spot
			else if (Input.GetKey(KeyCode.A))
			{
				Instantiate(playerbullet, BulletLocation3.position, BulletLocation3.rotation);
				shootCooldown = Time.time + 0.3f;
			}
			//we are idle so we use the center bullet spot
			else
			{
				Instantiate(playerbullet, BulletLocation2.position, BulletLocation2.rotation);
				shootCooldown = Time.time + 0.3f;
			}
			
		}
		
		//   for testing the transitions between animations
		//  if(Input.GetKey(KeyCode.Alpha1) && playerHealth < 3)//pickup health
		//  {
		//   playerHealth++;
		//  }
		//  if(Input.GetKey(KeyCode.Alpha2) && playerHealth > 3)//pickup health
		//  {
		//   playerHealth--;
		//  }
		if (Time.time > currentEnemyCooldown) 
		{
			
			Instantiate(Enemy);
			currentEnemyCooldown = Time.time + enemySpawn;
			Debug.Log (enemySpawn);
		}

		if (playerHealth <= 0.0f) {
			Application.LoadLevel(0);
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
//	void OnGUI() 
//	{
//		string result = GUI.TextField(new Rect(10.0f, 10.0f, 50.0f, 25.0f), playerHealth.ToString());
//	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Bullet(Clone)") {
			return;
		}


		//the damage and it has a cooldown for when you can take damage again
		if(Time.time > cooldown && playerHealth > 0)
		{
			
			playerHealth--;
			//sets the cooldown time
			cooldown = Time.time + 3.0f;
		}
	}
	
}