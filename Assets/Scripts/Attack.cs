using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
	public Animator a;

	public GameObject melee, ranged;
	public Transform mPlace, rPlace;
	private bool canAttack;

    // Update is called once per frame
    void Update()
    {
		// if(a.GetBool("canAttack")){
		if(Input.GetMouseButtonDown(0)) {
			a.SetTrigger("rangeAttack");
			// GameObject g = (GameObject)Instantiate(gun, place.position, place.rotation);
		} else if (Input.GetMouseButtonDown(1)) {
			a.SetTrigger("meleeAttack");
		}

		// }
	}

	public void Hit(int t) {
		if(t == 2) {
			Instantiate(melee, mPlace.position, mPlace.rotation);
		} else if (t == 1) {
			Instantiate(ranged, rPlace.position, rPlace.rotation);
		}
	}

	public void startAttack() {
			a.SetBool("canAttack", false);
	}

	public void endAttack() {
			a.SetBool("canAttack", true);
	}
}
