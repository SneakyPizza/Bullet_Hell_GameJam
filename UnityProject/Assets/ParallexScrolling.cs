using UnityEngine;
using System.Collections;

public class ParallexScrolling : MonoBehaviour 
{
	public float scrollSpeed;

	void Update () 
	{
		float x = Input.GetAxis("Horizontal");
		
		if (x != 0)
		{
			Vector2 movement = new Vector2(x * scrollSpeed, 0f);
			transform.Translate(movement);
		}
	}
}
