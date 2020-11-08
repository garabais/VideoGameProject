using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
	private Animator a;
	public EnemyPath p;

	public GameObject root;

    // Start is called before the first frame update
    void Start()
    {

		a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		a.SetFloat("angle", Vector3.SignedAngle(transform.forward, p.dir, Vector3.down));
    }

	public void hitDie(){
		print("hello");
		Destroy(root);
	}
}
