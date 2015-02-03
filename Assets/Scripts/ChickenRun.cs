using UnityEngine;
using System.Collections;

public class ChickenRun : MonoBehaviour {
	
	float x,y,z;
	Vector3 newPos;
	float oldHeight;
	float variation = 0.01f;

	void Start () 
	{
		oldHeight = transform.position.y;
	}
	
	void Update () 
	{
		x = Input.GetAxis ("Horizontal");
		y = Input.GetAxis ("Jump");
		z = Input.GetAxis ("Vertical");
		newPos = new Vector3 (transform.position.x + x*0.3f, transform.position.y + y, transform.position.z + z*0.3f);
		transform.position = newPos;
		if (x != 0 || z != 0)
		{
			animation.Play("Walk");
		}
		else
		{
			animation.Play("Idle");
		}
	}
}
