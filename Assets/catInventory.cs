using UnityEngine;
using System.Collections;

public class catInventory : MonoBehaviour {

	public ArrayList catList = new ArrayList(10);
	int catsInInventory = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void AddCat (Transform newCat) {
		catList.Add(newCat);
		catsInInventory ++;
		print ("added cat");
	}
	
	public Transform GetLastCat(){
		if (catsInInventory > 0){
			Transform lastCat = catList[catsInInventory] as Transform;
			return lastCat;
			catsInInventory ++;
		}
		else{
			return transform;
			catsInInventory ++;
		}
	}
}
