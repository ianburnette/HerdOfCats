using UnityEngine;
using System.Collections;

public class moveScript : MonoBehaviour {

	public float speed, rotationSpeed;
	playerAnimation plyrAnim;

	void Start(){
		plyrAnim = GetComponent<playerAnimation>();
	}
	
	public void Move (float h, float v) {
		rigidbody.velocity = new Vector3(h, 0, v) * speed * Time.deltaTime;
		plyrAnim.Animate(h,v);
		//Rotate();
		//Stop(h,v);
	}
	
	void Stop(float h, float v){
		if (h == 0){
			rigidbody.velocity = new Vector3(0,0,rigidbody.velocity.z);
		}
		if (v == 0){
			rigidbody.velocity = new Vector3(rigidbody.velocity.x,0,0);
		}
	}
	
	void Rotate(){
		if (rigidbody.velocity.magnitude != 0){
			transform.rotation = Quaternion.Slerp(
				transform.rotation, 
				Quaternion.LookRotation(rigidbody.velocity),
				Time.deltaTime * rotationSpeed
			);
		}
	}
}
