using UnityEngine;
using System.Collections;

public class catInventory : MonoBehaviour {

	public Transform[] catList;
	public int catsInInventory = 0;

	// Use this for initialization
	void Start () {
		catList = new Transform[10];
	}
	
	// Update is called once per frame
	public void AddCat (Transform newCat) {
		catList[catsInInventory] = newCat;
		catsInInventory ++;
	//	print ("added cat");
	}
	
	public Transform GetLastCat(){
		if (catsInInventory > 0){
			Transform lastCat = catList[catsInInventory-1];
			//catsInInventory ++;
			return lastCat;
		}
		else{
			return transform;
			//catsInInventory ++;
		}
	}
}
