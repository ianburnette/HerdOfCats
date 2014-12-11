using UnityEngine;
using System.Collections;

public class ropeScript : MonoBehaviour {

	public GameObject rope, ropeObject;

	void Start () {
		ropeObject = rope.transform.GetChild(0).gameObject;
		ropeObject.SetActive (false);
	}

	public void FireRope () {
		ropeObject.SetActive (true);
	}

	public void StopRope(){
		ropeObject.SetActive (false);
	}
}
