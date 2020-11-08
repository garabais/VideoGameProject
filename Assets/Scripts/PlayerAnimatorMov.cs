using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorMov : MonoBehaviour
{

	public Rigidbody rb;
	private Animator a;
	public Reset r;

    // Start is called before the first frame update
    void Start()
    {
		a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		a.SetFloat("angle", Vector3.SignedAngle(transform.forward, rb.velocity, Vector3.down));
		a.SetFloat("vel", rb.velocity.sqrMagnitude);

    }

	public void loadReset(){
		r.enabled = true;
	}
}
