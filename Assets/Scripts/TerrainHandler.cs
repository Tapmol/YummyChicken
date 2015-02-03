using UnityEngine;
using System.Collections.Generic;

public class TerrainHandler : MonoBehaviour {

	Terrain terrain;
	Vector3 terrainSize;
	float terrainWidth;
	float terrainHeight;
	float terrainLength;

	void Start () 
	{
		terrain = gameObject.GetComponent("Terrain") as Terrain;
		terrainSize = terrain.terrainData.size;
		terrainWidth = terrainSize.x;
		terrainHeight = terrainSize.y;
		terrainLength = terrainSize.z;
		for (int i = 0; i<terrainWidth / 10; i++)
		{
			for (int j = 0; j<terrainLength / 10; j++)
			{

			}
		}
	}
	
	void Update () 
	{

	}
}
