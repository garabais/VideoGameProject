using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDie : MonoBehaviour
{
	public static int lifes = 100;
	private static int life = 100;
	public Animator a;
	public Movement mov;
	public Rotation rot;
	public Dash da;
	public Attack at;
	public Text text;
	public bool hit;

	public GameObject over;
    // Start is called before the first frame update
    void Start()
    {
		hit = true;
		text = GameObject.Find("HP").GetComponent<Text>();
		text.text = life.ToString();
    }


	private void hitAllow(){
		hit = true;
	}

	private void OnTriggerEnter(Collider other) {
		// If the trigger is an enemy damage
		if(other.gameObject.layer == 9 && hit) {
			hit = false;

			Invoke("hitAllow", 0.5f);
			life--;
			if(life >= 0){
				text.text = life.ToString();

				if(life > 0) {
					a.SetTrigger("Hit");
					a.SetBool("canAttack", true);
				} else {
					a.SetBool("alive", false);
					if(over != null) {
						over.active = true;
					}
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

	public static void resetLifes(){
		life = lifes;
	}

	public static void extraLife(){
		life += Level.getLevel();
	}


}
