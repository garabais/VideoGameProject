using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
	public Animator a;
	public int lives = 3;
	public EnemyPath p;
	public Aim aim;
	public EnemyShoot s;

    // Start is called before the first frame update
    void Start()
    {
		lives *= Level.getLevel();
    }

	private void OnTriggerEnter(Collider other) {
		lives--;
		if(lives > 0) {
			a.SetTrigger("Hit");
		} else {
			p.enabled = false;
			aim.enabled = false;
			s.enabled = false;
			a.SetBool("canShoot", false);
			a.SetTrigger("Die");
			GetComponent<BoxCollider>().enabled = false;
		}
	}

}
