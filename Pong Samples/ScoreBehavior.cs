using UnityEngine;
using System.Collections;

public class ScoreBehavior : MonoBehaviour {

	public bool rightPlayer = false;

	void Update () {
		GetComponent<TextMesh> ().text = "" + (rightPlayer ? TriggerBehavior.rightScore : TriggerBehavior.leftScore);
	}
}
