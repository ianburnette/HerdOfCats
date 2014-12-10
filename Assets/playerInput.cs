using UnityEngine;
using System.Collections;

public class playerInput : MonoBehaviour {

	float h, v;
	moveScript mvScrpt;
	public bool player1 = false;
	
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
	}
	
	void GetInput(){
		if (player1){
			h = Input.GetAxisRaw("P1Horizontal");
			v = Input.GetAxisRaw("P1Vertical");
		}
		else {
			h = Input.GetAxisRaw("P2Horizontal");
			v = Input.GetAxisRaw("P2Vertical");
		}
		mvScrpt.Move(h,v);
	}
}
