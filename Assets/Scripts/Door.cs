using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

		Invoke("check", .25f);
    }

    // Update is called once per frame
    void Update()
    {

    }
	void check() {
		StartCoroutine(selfDestroy());
	}

	public IEnumerator selfDestroy() {
		while(GameObject.FindGameObjectsWithTag("Spawn").Length > 0 || GameObject.FindGameObjectsWithTag("Enemy").Length > 0) {
			yield return new WaitForSeconds(0.15f);
		}
		Destroy(gameObject);
	}
}
