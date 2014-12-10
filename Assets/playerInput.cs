using UnityEngine;
using System.Collections;

public class playerInput : MonoBehaviour {

	float h, v;
	moveScript mvScrpt;
	bool player1 = false;
	bool p1Fire, p2Fire;
	
	void Start(){
		mvScrpt = GetComponent<moveScript>();
		if (transform.tag == "player1"){
			player1 = true;
		}
		else{
			player1 = false;
		}
	}
	
	void FixedUpdate () {
		GetInput();
		CheckToFire();
	}
	
	void GetInput(){
		if (player1){
			h = Input.GetAxisRaw("P1Horizontal");
			v = Input.GetAxisRaw("P1Vertical");
			if (Input.GetButton("P1Fire1")){
				p1Fire = true;
			}
		}
		else {
			h = Input.GetAxisRaw("P2Horizontal");
			v = Input.GetAxisRaw("P2Vertical");
			if (Input.GetButton("P2Fire1")){
				p2Fire = true;
			}
		}
		mvScrpt.Move(h,v);
	}
}
