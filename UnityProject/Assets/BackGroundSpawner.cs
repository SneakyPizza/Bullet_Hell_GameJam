using UnityEngine;
using System.Collections;

public class BackGroundSpawner : MonoBehaviour 
{
	/*public GameObject background;


	/*GameObject[]backGround;
	public int backgroundReturn 	= 0;
	public int backgroundCache		= 2;

	void Update () 
	{
		backGround = new GameObject[backgroundCache];

		for(int i=0; i<backGround.Length; i++)
		{
			backGround[i] = new GameObject ("Midlane"+i);
		}
	}

	int nextBackGround()
	{
		backgroundReturn +=1;

		if(backgroundReturn > backgroundCache)
		{
			backgroundReturn = 0;
		}

		return backgroundReturn;
	}*/


	void OnTriggerExit (Collider col)
	{ 
		Debug.Log ("qwerty");
		if (collider.tag == "ResetCube")
		{
			Vector2 temp = new Vector2(background.transform.position.x - transform.position.x, 0);
			background.transform.position = new Vector3(temp.x, temp.y, 0);
			Vector2 newPosition = new Vector2(background.transform.position.x - transform.position.x,0);
			newPosition.x = 0;
			transform.position = newPosition;
		}
	}
}
	
	/*private int startPos;
	private float startRot;
	
	
	void Start() 
	{
		startPos = transform.position;
		startRot = transform.rotation;
	}
	
	
	void OnTriggerEnter(Collider col) 
	{
		if (col.tag == "ResetCube") 
		{
			Restart();
		}
	}
	
	
	void Restart() 
	{
		transform.position = startPos;
		transform.rotation = startRot;

		rigidbody.velocity = Vector3.zero;
		rigidbody.angularVelocity = Vector3.zero;
	}*/
}