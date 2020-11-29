using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{
	public GameObject calmG, angryG;
	public Transform place;
	public float calmD  = 1.25f;
	public float angryD  = 0.5f;
	public Animator a;
	private IEnumerator shoot;
	private GameObject curr;
	private float delay;

    // Start is called before the first frame update
    void Start()
    {
		curr = calmG;
		delay = calmD;
		shoot = Shoot();
		start();
    }

	public void start(){
		StartCoroutine(shoot);
	}

	public void stop(){
		StopCoroutine(shoot);
	}

	public void angry(){
		curr = angryG;
		delay = angryD;
	}

	public void calm(){
		curr = calmG;
		delay = calmD;
	}


	public IEnumerator Shoot() {
		while(true) {
			a.SetTrigger("Attack");
			yield return new WaitForSeconds(delay);
		}
	}

	public void Hit() {
			Instantiate(curr, place.position, place.rotation);
	}
}
