using UnityEngine;
using System.Collections;

public class ropeControls : MonoBehaviour {

	bool p1Fire, p2Fire, ropeActive;
	ropeScript rpScrpt;

	// Use this for initialization
	void Start () {
		rpScrpt = GetComponent<ropeScript> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GetInput ();
		CheckToFire();
	}

	void GetInput(){
		if (Input.GetButton("P1Fire1")){
			p1Fire = true;
		}
		if (Input.GetButton("P2Fire1")){
			p2Fire = true;
		}
		if (Input.GetButtonUp ("P1Fire1")) {
			p1Fire = false;
		}
		if (Input.GetButtonUp ("P2Fire1")) {
			p2Fire = false;
		}
	}

	void CheckToFire(){
		if (p1Fire && p2Fire && !ropeActive) {
			rpScrpt.FireRope();
			ropeActive = true;
		}
		if ((!p1Fire || !p1Fire) && ropeActive) {
			ropeActive = false;
			rpScrpt.StopRope();
		}
	}
}
