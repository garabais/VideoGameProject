using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed = 7;
	private Rigidbody rb;
	private AudioSource audio;
	private bool move;


    // Start is called before the first frame update
    void Start() {
		rb = GetComponent<Rigidbody>();
		audio = GetComponent<AudioSource>();
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

		if(movement.sqrMagnitude == 0 && move) {
			move = false;
			audio.Pause();

		} else if (movement.sqrMagnitude != 0 && !move){
			move = true;
			audio.Play();
		}

		// rb.AddForce(movement * speed);
		rb.velocity = movement * speed;
    }

	public void stop() {
		rb.velocity = new Vector3(0,0,0);
	}

}
