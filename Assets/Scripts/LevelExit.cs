using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExit : MonoBehaviour
{
	private MeshRenderer mesh;
	private BoxCollider coll;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
		coll = GetComponent<BoxCollider>();
		Invoke("check", .25f);
    }

	private void OnTriggerEnter(Collider other) {
		Level.next();
	}

	void check() {
		StartCoroutine(wait());
	}

	void activate() {
		mesh.enabled = true;
		coll.enabled = true;
	}

	public IEnumerator wait() {
		while(GameObject.FindGameObjectsWithTag("Spawn").Length > 0 || GameObject.FindGameObjectsWithTag("Enemy").Length > 0) {
			yield return new WaitForSeconds(0.15f);
		}
		activate();
	}
}
