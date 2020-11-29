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
	private bool vul;

    // Start is called before the first frame update
    void Start()
    {
		lives *= Level.getLevel();
    }

	private void OnTriggerEnter(Collider other) {
		if(vul){
			lives -= 2;
		} else {
			lives--;
		}
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

	public void recover(){
		int l = Level.getLevel();
		if(l < 10) {
			lives += l;
		} else {
			lives += 10;
		}
	}

	public void vulnerable(){
		vul = true;
	}

	public void normal(){
		vul = false;
	}

}
