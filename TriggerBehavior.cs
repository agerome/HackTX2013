using UnityEngine;
using System.Collections;

public class TriggerBehavior : MonoBehaviour {

	public static int leftScore, rightScore;
	public bool leftPlayer = false;
	public AudioClip scoreSound;

	IEnumerator Score (PuckBehavior puck) {
		yield return new WaitForSeconds (1);

		if (leftPlayer) {
			rightScore += 1;
		} else {
			leftScore += 1;
		}

		if (scoreSound) {
			AudioSource.PlayClipAtPoint(scoreSound, Vector3.zero);
		}

		puck.Reset ();
	}

	void OnTriggerEnter (Collider other) {
		PuckBehavior puck = other.gameObject.GetComponent<PuckBehavior> ();
		if (!puck) {
			return;
		}

		StartCoroutine (Score (puck));
	}
}
