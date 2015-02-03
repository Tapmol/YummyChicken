using UnityEngine;
using System.Collections;

public class CameraBob : MonoBehaviour {

	void Start () 
	{
	
	}
	
	void Update () 
	{
		GameObject michel = GameObject.FindGameObjectWithTag ("Player");
		transform.position = new Vector3 
			(michel.transform.position.x, michel.transform.position.y + 2, michel.transform.position.z -5);
	}
}
