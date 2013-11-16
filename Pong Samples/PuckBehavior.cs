using UnityEngine;
using System.Collections;

public class PuckBehavior : MonoBehaviour {

	private float speed = 100;

	void Start () {
		Reset ();
	}

	public void Reset () {
		transform.position = Vector3.zero;
		rigidbody.velocity = Vector3.one * speed;
	}

	void FixedUpdate () {
		rigidbody.velocity = rigidbody.velocity.normalized * speed;
	}
}
