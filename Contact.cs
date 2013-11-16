using UnityEngine;
using System.Collections;

public class Contact : MonoBehaviour {

	public int num = 1;

	int OnCollisionStart (Collision collision) {
		if (collision.gameObject.name == "Ground") {
			 num = 2;
		}else{
			 num = 1;
		}
		return num;
	}
}

