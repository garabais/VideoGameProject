using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 10;
	public float ttl = 10;

    // Start is called before the first frame update
    void Start()
    {
		Destroy(gameObject, ttl);
    }

    // Update is called once per frame
    void Update()
    {
		transform.Translate(speed * transform.up * Time.deltaTime, Space.World);
    }

	private void OnTriggerEnter(Collider other) {
		Destroy(gameObject);
	}
}
