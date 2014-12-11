using UnityEngine;
using System.Collections;

public class catCatch : MonoBehaviour {

	int curPlayer = 1;
	public Transform player1, player2;

	// Use this for initialization
	void Start () {
		player1 = GameObject.Find("player1").transform;
		player2 = GameObject.Find("player2").transform;
	}

	void OnTriggerEnter (Collider col) {
		print ("trigger entered by " + col.transform);
		if (col.transform.tag == "cat"){
			if (curPlayer == 1){
				col.transform.parent.GetComponent<catBehavior>().SetTarget(player2);
				curPlayer = 0;
			}
			else if (curPlayer == 0){
				col.transform.parent.GetComponent<catBehavior>().SetTarget(player1);
				curPlayer = 1;
			}
		}
	}
}
