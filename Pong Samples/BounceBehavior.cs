using UnityEngine;
using System.Collections;

public class BounceBehavior : MonoBehaviour {

	public bool bounceX, bounceY = false;
	public AudioClip bounceSound;

	void OnCollisionEnter (Collision collision) {
		if (!collision.gameObject.GetComponent<PuckBehavior> ()) {
			return;
		}

		Vector3 vel = collision.rigidbody.velocity;
		vel.x = bounceX ? -vel.x : vel.x;
		vel.y = bounceY ? -vel.y : vel.y;
		collision.rigidbody.velocity = 5*vel;

		if (bounceSound) {
			AudioSource.PlayClipAtPoint (bounceSound, Vector3.zero);
		}
	}
}
