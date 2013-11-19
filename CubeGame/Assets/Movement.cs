using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	//public Contact other;
	private float speed = 4;
	private float vertical = 0;
	private float jump = 1;

	float gravity (float vertical){
				vertical = vertical - 1;
				return vertical;
	}



	void Update () {
		float horizontal = 0;
		if(Input.GetKey (KeyCode.LeftArrow)){
			horizontal -= 3;
			vertical = 0;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			horizontal += 3;
			vertical = 0;
		}
		if (vertical >= -6) {
			vertical = gravity (vertical);
		}

		/*Contact Contact;
		Contact = GetComponent (Contact);
		int i = Contact.num;
		
		/*GameObject HERO = GameObject.Find ("HERO");
		Contact contact = HERO.GetComponent<Contact> ();
		Contact.num = Contact.num;





		if (Contact.num ==  2) {
						if (Input.GetKey (KeyCode.UpArrow)) {
								vertical = 6;
						}
				}*/


		rigidbody.velocity = new Vector3 (horizontal * speed, vertical*speed, 0);
	}
}

/*public class Contacts : MonoBehaviour {
	
	public int num = 1;
	
	int OnCollisionStay (Collision collision) {
		if (collision.gameObject.name == "Ground") {
			num = 2;
		}else{
			num = 1;
		}
		return num;
	}
}*/

	