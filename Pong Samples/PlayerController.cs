using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private float speed = 10;
	public bool leftPlayer = false;


	void Update () {
		float vertical = 0;
		if (leftPlayer) {
			if (Input.GetKey (KeyCode.W)) {
				vertical += 1;
			}
			if (Input.GetKey (KeyCode.S)) {
				vertical -= 1;
			}
		}else{
			if (Input.GetKey (KeyCode.UpArrow)) {
				vertical += 1;
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				vertical -= 1;
			}
		}

		rigidbody.velocity = new Vector3 (0, vertical*speed, 0);
	}
}