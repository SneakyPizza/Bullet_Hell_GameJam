using UnityEngine;
using System.Collections;

public class BackGroundSpawner : MonoBehaviour 
{
	public GameObject background;

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

	void OnTriggerExit(Collider col)
	{
		Debug.Log ("qwerty");
		if (collider.tag == "ResetCube")
		{
			Vector2 temp = new Vector2(background.transform.position.x - transform.position.x, 0);
			background.transform.position = new Vector3(temp.x, temp.y, 0);
		}
	}
}


