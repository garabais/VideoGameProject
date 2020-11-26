using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject enemy;
	public int number = 5;
	public float delay = 5;
	public float startDelay = 0;

    // Start is called before the first frame update
    void Start()
    {
		Invoke("startSpawn", startDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

	void startSpawn() {
		StartCoroutine(Spawn());
	}

	public IEnumerator Spawn() {
		while(number > 0) {
			Instantiate(enemy, transform.position, enemy.transform.rotation);
			number--;
			yield return new WaitForSeconds(delay);
		}
		Destroy(gameObject);
	}
}
