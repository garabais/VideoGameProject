using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
	public Rigidbody rb;
	private bool dash;

	public float boostSpeed = 2;

	public Animator a;

    // Start is called before the first frame update
    void Start()
    {
		dash = false;
    }

    // Update is called once per frame
    void Update()
    {
		if(!dash) {
			if(Input.GetKeyDown(KeyCode.Space)) {
				a.SetBool("canAttack", false);
				a.SetTrigger("Dash");
			}
		}
	}

	void LateUpdate() {
		if(dash) {
			rb.velocity = rb.velocity * boostSpeed;
		}
    }

	public void startDash() {
				dash = true;
	}

	public void endDash() {
				dash = false;
				a.SetBool("canAttack", true);
	}

}
