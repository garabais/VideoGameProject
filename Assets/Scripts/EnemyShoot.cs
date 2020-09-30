using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
	public GameObject gun;
	public Transform place;
	public float delay  = 0.5f;
	public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
    }

	public IEnumerator Shoot() {
		while(true) {
			GameObject g = (GameObject)Instantiate(gun, place.position, place.rotation);
			SetLayerRecursively(g, 9);
			yield return new WaitForSeconds(delay);
		}
	}

	void SetLayerRecursively(GameObject obj, int newLayer)
    {
        if (null == obj)
        {
            return;
        }

        obj.layer = newLayer;

        foreach (Transform child in obj.transform)
        {
            if (null == child)
            {
                continue;
            }
            SetLayerRecursively(child.gameObject, newLayer);
        }
    }
}
