using UnityEngine;
using System.Collections;

public class UilEnemy : MonoBehaviour {
	
	public AudioClip clip;
	public Transform laser;
	public Transform laserSpawnPoint;
	//public Animation prebeam;
	float cooldown;
	// Use this for initialization
	void Start () 
	{
		
		transform.position = new Vector3(Screen.width / 4 + renderer.bounds.size.x, Random.Range(-50.0f, 50.0f), transform.position.z);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		//moves the enemy to x position where it will remain stationairy
		if(transform.position.x > 10.0f)
		{
			transform.Translate(-20.0f * Time.deltaTime,0.0f,0.0f);
			if(transform.position.x <= 52.0f)
			{
				// set the cooldown for the first shot
				cooldown = Time.time + 3.0f;
				//    animation.Play("PreBeam");
				//animation["PreBeam"].speed = 0.08f;
			}
		}
		
		//shooting + set the cooldown
		else if(Time.time > cooldown)
		{
			Shoot ();
			cooldown = Time.time + 6.0f;
			
		}
		
		
	}
	
	//the instantiate of the shooting
	void Shoot()
	{
		Instantiate(laser, laserSpawnPoint.position, laserSpawnPoint.rotation);
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		audio.PlayOneShot(clip, 0.5f);

		if (other.tag != "Laser" || other.tag != "Enemy")
		{
			float enemySpawnCoolDown = GameObject.Find("PlayerSprite").GetComponent<PlayerScript>().enemySpawn;
			enemySpawnCoolDown -= 0.1f;
			Destroy(this.gameObject);
			if(other.tag != "Player")
			{
				Destroy (other.gameObject);
			}
			
		}
		
	}
	
}