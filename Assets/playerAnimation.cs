using UnityEngine;
using System.Collections;

public class playerAnimation : MonoBehaviour {

	Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}
	
	public void Animate(float h, float v) {
		if (Mathf.Abs(h) > 0 || Mathf.Abs(v) > 0)
			anim.SetBool("moving", true);
		else
			anim.SetBool("moving", false);

		if (h>0 && h>Mathf.Abs(v)) //moving right
			anim.SetInteger("facingDir", 4);
		else if (h<0 && Mathf.Abs(h) > Mathf.Abs(v)) //left
			anim.SetInteger("facingDir", 3);
		else if (v>0 && v>Mathf.Abs(h)) //moving up
			anim.SetInteger("facingDir", 1);
		else if (v<0 && Mathf.Abs(v) > Mathf.Abs(h)) //down
			anim.SetInteger("facingDir", 2);
	}
}
