using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
	public int lives = 3;
	public Animator a;
	public Movement mov;
	public Rotation rot;
	public Dash da;
	public Attack at;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

	private void OnTriggerEnter(Collider other) {
		// transform.position = new Vector3(0,0.5f,0);
		lives--;
		if(lives > 0) {
			a.SetTrigger("Hit");
			a.SetBool("canAttack", true);
		} else {
			mov.enabled = false;
			rot.enabled = false;
			da.enabled = false;
			at.enabled = false;
			a.SetTrigger("Die");
		}
		// print("DIE");
	}
}
