﻿using UnityEngine;
using System.Collections;

public class moveScript : MonoBehaviour {

	public float speed;

	public void Move (float h, float v) {
		rigidbody.velocity = new Vector3(h, 0, v) * speed * Time.deltaTime;
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
}