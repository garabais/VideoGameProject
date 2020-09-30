using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
	public float ttl = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
		Destroy(gameObject, ttl);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
