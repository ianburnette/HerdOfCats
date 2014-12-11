using UnityEngine;
using System.Collections;

public class catBehavior : MonoBehaviour {

	NavMeshAgent nav;
	public Vector3[] waypoints;
	public float margin;

	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		nav.destination = waypoints [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(transform.position, waypoints [1]) < margin) {
			nav.destination = waypoints [0];
		} 
		else if (Vector3.Distance(transform.position, waypoints [0]) < margin) {
			nav.destination = waypoints [1];
		}
	}
}
