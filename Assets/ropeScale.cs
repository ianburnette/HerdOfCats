using UnityEngine;
using System.Collections;

public class ropeScale : MonoBehaviour {

	public GameObject player1, player2, ropeMesh, midpoint;
	float distance;

	// Use this for initialization
	void Start () {
		player1 = GameObject.Find("player1");
		player2 = GameObject.Find("player2");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.LookAt(player1.transform.position);
		distance = Vector3.Distance(player1.transform.position, player2.transform.position);
		ropeMesh.transform.localScale = new Vector3(transform.localScale.x, distance/2, transform.localScale.z);
	}
}
