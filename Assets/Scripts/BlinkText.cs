using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkText : MonoBehaviour
{
	private Text text;
    // Start is called before the first frame update
    void Start()
    {
		text = GetComponent<Text>();
		Invoke("startBlink", 0.75f);
    }

	void startBlink(){
		StartCoroutine(blink());
	}
	 public IEnumerator blink() {
		while(true) {
			text.enabled = !text.enabled;
			yield return new WaitForSeconds(0.75f);
		}
	}
}
