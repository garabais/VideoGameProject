using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDie : MonoBehaviour
{
	public static int lifes = 3;
	private static int life = 3;
	public Animator a;
	public Movement mov;
	public Rotation rot;
	public Dash da;
	public Attack at;
	public Text text;

    // Start is called before the first frame update
    void Start()
    {
		text = GameObject.Find("HP").GetComponent<Text>();
		text.text = life.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

	private void OnTriggerEnter(Collider other) {
		// If the trigger is an enemy damage
		if(other.gameObject.layer == 9) {
			life--;
			if(life >= 0){
				text.text = life.ToString();

				if(life > 0) {
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

	public static void resetLifes(){
		life = lifes;
	}

	public static void extraLife(){
		life++;
	}


}
