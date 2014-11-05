using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

	public Transform laserScale;
	float stationairyShootTime;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		//length of the shot
		if (stationairyShootTime < 3)
		{
			laserScale.localScale += new Vector3(1.0F, 0, 0);
			stationairyShootTime += Time.deltaTime;
			
		}
		//moves the laser out of the screen
		if (stationairyShootTime > 3)
		{
			transform.Translate(-1.0f,0.0f,0.0f);

		}
		//destroys the laser when it is out of screen
		if(transform.position.x < -18)
		{
			Destroy(this.gameObject);

		}

	}

}
