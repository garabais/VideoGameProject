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
		// If the trigger is an enemy damage
		if(other.gameObject.layer == 9) {
			lives--;
			if(lives > 0) {
				a.SetTrigger("Hit");
				a.SetBool("canAttack", true);
			} else {
				mov.stop();
				mov.enabled = false;
				rot.enabled = false;
				da.enabled = false;
				at.enabled = false;
				a.SetTrigger("Die");
			}
		}
	}
}
