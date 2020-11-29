using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossState : MonoBehaviour
{
	public BossShoot shooter;
	public GameObject light;
	public EnemyPath mov;
	public Aim rotat;

	public int calmDelay = 15;
	public int tiredDelay = 5;
	private int state;

	public Animator a;
    // Start is called before the first frame update
    void Start()
    {
		// angry.enabled = false;
        state = 1;

		Invoke("getTired", calmDelay);
    }

	private void getTired(){
		state = 2;
		shooter.stop();
		mov.stop();
		rotat.enabled = false;
		a.SetTrigger("Tired");

		Invoke("getCalm", tiredDelay);
	}

	private void getCalm(){
		if(state == 2){
			mov.start();
			rotat.enabled = true;
			a.SetTrigger("Mov");
			state = 1;
			shooter.start();
			Invoke("getTired", calmDelay);
		}
	}

	private void angryCalm(){
			light.active = false;
			shooter.stop();
			shooter.calm();
			state = 1;
			shooter.start();
			Invoke("getTired", calmDelay);
	}

	private void getAngry(){
		if(state == 2) {
			state = 3;
			shooter.stop();
			shooter.angry();
			shooter.start();
			mov.start();
			rotat.enabled = true;
			light.active = true;
			// a.SetTrigger("Mov");
			Invoke("angryCalm", calmDelay);
		}
	}

    // Update is called once per frame
    void Update()
    {

    }

	private void OnTriggerEnter(Collider other) {
		getAngry();
	}
}
