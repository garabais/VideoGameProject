using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed = 15;
	public float boostSpeed = 30;

    // Start is called before the first frame update
    void Start() {
	}

    // Update is called once per frame
    void Update() {
		float vertical = 0;
		float horizontal = 0;
		float boost = 1;

		// Get each movement key
		if(Input.GetKey(KeyCode.W)) {
			vertical += 1;
		}
		if(Input.GetKey(KeyCode.S)) {
			vertical -= 1;
		}
		if(Input.GetKey(KeyCode.D)) {
			horizontal += 1;
		}
		if(Input.GetKey(KeyCode.A)) {
			horizontal -= 1;
		}

		if(Input.GetKeyDown(SpacebarKey())) {
			boost = boostSpeed;
		}

		// Make movement vector
		Vector3 movement = new Vector3(horizontal,0,vertical);
		movement = Quaternion.Euler(0,45,0) * movement;

		transform.Translate(movement * boost * speed * Time.deltaTime);
    }

	// In linux there's a bug that in editor mode spacebar is detected as an O
	// This kinda solves this issue
	public static KeyCode SpacebarKey() {
	if (Application.isEditor) return KeyCode.O;
	else return KeyCode.Space;
	}
}
