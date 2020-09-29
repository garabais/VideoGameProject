﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed = 7;
	private Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
		rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update() {
		float vertical = 0;
		float horizontal = 0;

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

		// Make movement vector
		Vector3 movement = new Vector3(horizontal,0.0f,vertical);

		// rb.AddForce(movement * speed);
		rb.velocity = movement * speed;
    }

}
