using UnityEngine;
using System.Collections;

public class cameraAdjustor : MonoBehaviour {

	public Transform player1, player2;
	cameraFace cmFcScrpt;
	public float minDist, maxDist, minHeight, maxHeight, changeSpeed;
	float dist;

	// Use this for initialization
	void Start () {
		cmFcScrpt = GetComponent<cameraFace>();
		minDist = cmFcScrpt.distance;
		minHeight = cmFcScrpt.height;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		CheckDistance();
		AdjustPosition();
	}
	
	void CheckDistance(){
		dist = Vector3.Distance(player1.position, player2.position);
	}
	
	void AdjustPosition(){
		if (dist > minDist && dist < maxDist){
			cmFcScrpt.distance = Mathf.Lerp(cmFcScrpt.distance, dist, changeSpeed * Time.deltaTime);
			cmFcScrpt.height = Mathf.Lerp(cmFcScrpt.height, dist/2+1, changeSpeed * Time.deltaTime);
		}
	}
}
