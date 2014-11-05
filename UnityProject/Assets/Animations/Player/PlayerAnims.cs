using UnityEngine;
using System.Collections;

public class PlayerAnims : MonoBehaviour
{
	//ForwardAnim3B                             = 0
	
	//Forward3B to Forward2B    = 1
	//Forward2B to Forward1B    = 2
	
	//Forward3B to Shoot3B              = 3
	//Forward2B to Shoot2B              = 4
	//Forward1B to Shoot1B              = 5
	
	//Forward3B to Back3B               = 6
	//Forward2B to Back2B               = 7
	//Forward1B to Back1B               = 8
	
	//Back3B    to backShoot3B  = 9
	//Back2B    to BackShoot2B  = 10
	//Back1B    to BackShoot1B  = 11
	
	public Animator animator;
	
	void Start()
	{
		
	}
	
	void Update()
	{
		int playerLives = (int)GetComponent<PlayerScript>().playerHealth;
		// if lives = 3
		if (playerLives == 3)
		{
			if (Input.GetKey(KeyCode.D))
			{
				animator.SetInteger("PlayerControl", 0);
				
				if (Input.GetKey(KeyCode.Space))
				{
					animator.SetInteger("PlayerControl", 3);
				}
			}
			
			if (Input.GetKey(KeyCode.A))
			{
				animator.SetInteger("PlayerControl", 6);
				if (Input.GetKey(KeyCode.Space))
				{
					animator.SetInteger("PlayerControl", 9);
				}
			}
		}
		
		// if lives = 2
		if (playerLives == 2)
		{
			if (Input.GetKey(KeyCode.D))
			{
				animator.SetInteger("PlayerControl", 1);
				
				if (Input.GetKey(KeyCode.Space))
				{
					animator.SetInteger("PlayerControl", 4);
				}
			}
			
			if (Input.GetKey(KeyCode.A))
			{
				animator.SetInteger("PlayerControl", 7);
				
				if (Input.GetKey(KeyCode.Space))
				{
					animator.SetInteger("PlayerControl", 10);
				}
			}
		}
		
		// if lives = 1
		if (playerLives == 1)
		{
			
			if (Input.GetKey(KeyCode.D))
			{
				animator.SetInteger("PlayerControl", 2);
				
				if (Input.GetKey(KeyCode.Space))
				{
					animator.SetInteger("PlayerControl", 5);
				}
			}
			
			if (Input.GetKey(KeyCode.A))
			{
				animator.SetInteger("PlayerControl", 8);
				
				if (Input.GetKey(KeyCode.Space))
				{
					animator.SetInteger("PlayerControl", 11);
				}
			}
		}
	}
}