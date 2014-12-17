using UnityEngine;
using System.Collections;

public class catBehavior : MonoBehaviour {

	NavMeshAgent nav;
	public int numberOfWaypoints;
	public Vector3[] waypoints;
	public float margin, range;
	bool saved = false;
	public float initialStoppingDistance, savedStoppingDistance;
	public Transform followTarget;
	public LayerMask savedMask, groundMask;
	playerAnimation plyrAnim;
	Transform catSprite;

	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		nav.destination = waypoints [0];
		nav.stoppingDistance = initialStoppingDistance;
		PopulateWayPoints();
		plyrAnim = GetComponent<playerAnimation>();
		catSprite = transform.GetChild(1);
	}
	
	// Update is called once per frame
	void Update () {
		plyrAnim.Animate(nav.velocity.x, nav.velocity.z);
		MaintainOrientation();
		if (!saved){
			Wander();
		}
		else{
			Follow();
		}
	}
	
	void Wander(){
		if (Vector3.Distance(transform.position, waypoints [1]) < margin) {
			nav.destination = waypoints [0];
		} 
		else if (Vector3.Distance(transform.position, waypoints [0]) < margin) {
			nav.destination = waypoints [1];
		}
	}
	
	public void SetTarget(Transform target){
		//print ("setting target");
		catInventory invScrpt = target.GetComponent<catInventory>();
		
		followTarget = invScrpt.GetLastCat();
		print ("followTarget is " + followTarget);
		invScrpt.AddCat(transform);
		nav.destination = followTarget.position;
		nav.stoppingDistance = savedStoppingDistance;
		saved = true;
		gameObject.layer = 10;
		transform.GetChild(0).gameObject.layer = 10;
	}	
	
	public void Follow(){
		nav.destination = followTarget.position;
	}
	
	public void PopulateWayPoints(){
		for (int i = 0; i < numberOfWaypoints; i++){
			Vector3 generatedPosition = new Vector3 (Random.Range(-range,range), 0, Random.Range(-range,range));
			NavMeshHit hit;
			if (NavMesh.SamplePosition(generatedPosition, out hit, range, groundMask)){
				waypoints[i] = hit.position;
			}
			else{
				i++;
			}
		}
	}
	
	void MaintainOrientation(){
		catSprite.eulerAngles = new Vector3(90,0,0);
	}
}
