using UnityEngine;
using System.Collections;

public class ParallaxEffect : MonoBehaviour 
{
	public float scrollSpeed;
    public float actualSpeed;
	void Update () 
	{
		float x = Input.GetAxis("Horizontal");
		if (x > 0)
		{
			Vector2 movement = new Vector2(x * scrollSpeed , 0f);
			transform.Translate(movement);
            actualSpeed = x * scrollSpeed;
		}
        
	}
}
