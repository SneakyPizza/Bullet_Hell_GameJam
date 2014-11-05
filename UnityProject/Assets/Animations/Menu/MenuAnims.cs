using UnityEngine;
using System.Collections;

public class MenuAnims : MonoBehaviour 
{
	public Animator animator;
	
	// Use this for initialization

	void Start () 
	{

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//animation
		animator.SetInteger("MenuControl", 0);

		/*if mouse down 
		{
		//Hover effect
		 animator.SetInteger("MenuControl", 1);

 		if(clicked) 
 		{
 		//Shrink
 		animator.SetInteger("MenuControl", 2);
 		}

		}*/
	
	}
}
