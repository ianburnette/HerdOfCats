using UnityEngine;
using System.Collections;

public class hoverBetweenCharacters : MonoBehaviour {

	public GameObject player1, player2;

	void FixedUpdate () {
		transform.position = ((player1.transform.position - player2.transform.position) * 0.5f) + player2.transform.position;
	}
}
