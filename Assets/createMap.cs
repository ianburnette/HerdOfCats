using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class createMap : MonoBehaviour {

	public GameObject levelTile, startingTile;
	public int roomNumber, gridSize;
	public float xOffsetSize = 40;
	public float yOffsetSize = 25;
	public Vector2 mapPosition;
	bool[,] map;// = new bool[gridSize,gridSize];

	// Use this for initialization
	void Start () {
		map = new bool[gridSize,gridSize];
		mapPosition = new Vector2 (gridSize, gridSize / 2);
		startingTile.transform.position = new Vector3 (mapPosition.x * xOffsetSize, 0, mapPosition.y * yOffsetSize);
		CreateSnake ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateSnake(){
		for (int i = 0; i < roomNumber; i++) {
			int directionToMove = PickDirection();
			UpdateMapLocation(directionToMove);
			GameObject newTile = Instantiate (levelTile, new Vector3(mapPosition.x * xOffsetSize, 0, mapPosition.y * yOffsetSize), Quaternion.identity) as GameObject;
		}
	}

	int PickDirection(){
		int rand = 0; 
		if (mapPosition.x == gridSize) { //I'm on the bottom layer
			while (rand == 0 || rand == 2) { //rand has not been chosen or is equal to down
				rand = Random.Range (1, 5);
			}
			return rand;
		} 
		else if (mapPosition.x == 0) {
			while (rand == 0 || rand == 1) { //rand has not been chosen or is equal to up
				rand = Random.Range (1, 5);
			}
			return rand;
		}
		else if (mapPosition.y == 0) { //on left side of map
			while (rand == 0 || rand == 3) { //rand has not been chosen or is equal to left
				rand = Random.Range (1, 5);
			}
			return rand;
		}
		else if (mapPosition.y == gridSize) { //on right side of map
			while (rand == 0 || rand == 4) { //rand has not been chosen or is equal to right
				rand = Random.Range (1, 5);
			}
			return rand;
		}
		rand = Random.Range (1, 5);
		return rand;
	}

	void UpdateMapLocation(int dir){
		if (dir == 1)
			mapPosition += Vector2.up;
		else if (dir == 2)
			mapPosition -= Vector2.up;
		else if (dir == 3) 
			mapPosition -= Vector2.right;
		else if (dir == 4)
			mapPosition += Vector2.right;
		print ("new map pos is " + mapPosition + " because of " + dir);
	}
}
