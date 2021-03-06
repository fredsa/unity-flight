﻿using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour
{
	public GameObject buildingPrefab;

	void Awake ()
	{
		for (int x = 0; x < Constants.GRID_SIZE; x += Constants.SPACING) {
			for (int z = 0; z < Constants.GRID_SIZE; z += Constants.SPACING) {
				float height = (float)Random.Range (Constants.MIN_HEIGHT, Constants.MAX_HEIGHT);
				DrawBuildings (x, z, height);
			}
		}
	}

	void DrawBuildings (int x, int z, float height)
	{
		for (int xx = -Constants.REPEAT_SIZE; xx < Constants.REPEAT_SIZE; xx++) {
			for (int zz = -Constants.REPEAT_SIZE; zz < Constants.REPEAT_SIZE; zz++) {
				SpawnBuilding (xx * Constants.GRID_SIZE + x, zz * Constants.GRID_SIZE + z, height);
			}
		}
	}

	void SpawnBuilding (int x, int z, float height)
	{
		Vector3 pos = new Vector3 (x, .5f * height, z);
		Vector3 scale = new Vector3 (.5f * Constants.SPACING, height, .5f * Constants.SPACING);
		GameObject clone = Instantiate (buildingPrefab);
		clone.transform.position = pos;
		clone.transform.localScale = scale;
	}

}
