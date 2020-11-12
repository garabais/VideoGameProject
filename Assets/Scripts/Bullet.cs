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
		transform.Translate(speed * transform.forward * Time.deltaTime, Space.World);
		transform.Rotate(0, 0, speed);
    }

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.layer != 9){
			Destroy(gameObject);
		}
	}
}
