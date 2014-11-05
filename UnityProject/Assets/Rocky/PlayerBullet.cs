using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {

	 //Update is called once per frame
	void Update () 
	{
		transform.Translate (1.0f,0.0f,0.0f);

		if (transform.position.x > 220.0f)
		{
			Destroy (this.gameObject);
		}
	}
}
