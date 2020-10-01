using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
	private Rigidbody rb;
	private bool dash;
	private float crDash;

	public float boostSpeed = 2;
	public float dashTimeout = 0.5f;
	public float dashTime = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
		crDash = dashTimeout;
    }

    // Update is called once per frame
    void Update()
    {
		if(dashTimeout <= crDash) {
			if(Input.GetKeyDown(SpacebarKey())) {
				crDash = 0;
				dash = true;
			}
		} else {
			crDash += Time.deltaTime;

			if(dashTime < crDash) {
				dash = false;
			}
		}
    }

	void LateUpdate() {
		if(dash) {
			rb.velocity = rb.velocity * boostSpeed;
		}
    }

	// In linux there's a bug that in editor mode spacebar is detected as an O
	// This kinda solves this issue
	public static KeyCode SpacebarKey() {

	if (Application.platform == RuntimePlatform.LinuxEditor) return KeyCode.O;
	else return KeyCode.Space;
	}
}
