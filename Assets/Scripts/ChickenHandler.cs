using UnityEngine;
using System.Collections;

public class ChickenHandler : MonoBehaviour {

	GameObject mainGame;
	Game mainScript;
	public int chickenId;
	bool moved;
	static GameObject cam;
	static Grid gr;
	static float w;
	static float h;
	bool[] egged;
	Vector3 oldCoordinates;
	float tileId;
	int oldTileId;

	void Start () 
	{
		cam = GameObject.Find("MainCamera");
		gr = cam.GetComponent("Grid") as Grid;
		mainGame = GameObject.Find("Grid");
		mainScript = mainGame.GetComponent("Game") as Game;
		w = gr.gridSizeX / gr.smallStep;
		h = gr.gridSizeY / gr.smallStep;
		for(int i = 0; i<w; i++)
		{
			for (int j = 0; j<h; j++)
			{
				egged[i*j] = false;
			}
		}
		oldCoordinates = transform.position;
		moved = false;
		switch(chickenId)
		{
			case 1 : oldTileId = (int)w;
			break;

			case 2 : oldTileId = (int) (w * (h-1));
			break;
		}
	}
	
	void Update () 
	{
		if(mainScript.turn % 2 == 0 && chickenId == 1)
		{
			if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.z < 92)
			{
				transform.position = new Vector3(transform.position.x, transform.position.y,transform.position.z + 10);
				audio.Play();
				mainScript.turn ++;
				moved = true;
				tileId -= w;
			}
		
			else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.z > 2)
			{
				transform.position = new Vector3(transform.position.x, transform.position.y,transform.position.z - 10);
				audio.Play();
				mainScript.turn ++;
				moved = true;
				tileId += w;
			}

			else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > 5)
			{
				transform.position = new Vector3(transform.position.x - 10, transform.position.y,transform.position.z);
				audio.Play();
				mainScript.turn ++;
				moved = true;
				tileId -= 1;
			}
		
			else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 95)
			{
				transform.position = new Vector3(transform.position.x + 10, transform.position.y,transform.position.z);
				audio.Play();
				mainScript.turn ++;
				moved = true;
				tileId += 1;
			}
		}
		else if (mainScript.turn % 2 == 1 && chickenId == 2)
		{
			if ( Input.GetKeyDown(KeyCode.Z) && transform.position.z < 92)
			{
				transform.position = new Vector3(transform.position.x, transform.position.y,transform.position.z + 10);
				audio.Play();
				mainScript.turn ++;
				moved = true;
				tileId -= w;
			}
		
			else if (Input.GetKeyDown(KeyCode.S) && transform.position.z > 2)
			{
				transform.position = new Vector3(transform.position.x, transform.position.y,transform.position.z - 10);
				audio.Play();
				mainScript.turn ++;
				moved = true;
				tileId += w;
			}

			else if ( Input.GetKeyDown(KeyCode.Q) && transform.position.x > 5)
			{
				transform.position = new Vector3(transform.position.x - 10, transform.position.y,transform.position.z);
				audio.Play();
				mainScript.turn ++;
				moved = true;
				tileId -= 1;
			}
		
			else if  (Input.GetKeyDown(KeyCode.D) && transform.position.x < 95)
			{
				transform.position = new Vector3(transform.position.x + 10, transform.position.y,transform.position.z);
				audio.Play();
				mainScript.turn ++;
				moved = true;
				tileId += 1;
			}
		}
		
		if(moved)
		{
			/*egged[oldTileId] = true;
			var sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        	sphere.transform.position = oldCoordinates;*/
			moved = false;
		}
	}
}
