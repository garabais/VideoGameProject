using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
	public GameObject gun;
	public Transform place;
	public int button;

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButtonDown(button)) {
			GameObject g = (GameObject)Instantiate(gun, place.position, place.rotation);
			SetLayerRecursively(g,8);
		}
	}

	private void OnTriggerEnter(Collider other) {
		transform.position = new Vector3(0,0,0);
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
