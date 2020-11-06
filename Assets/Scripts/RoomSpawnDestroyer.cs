using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawnDestroyer : MonoBehaviour
{
	private void OnTriggerEnter(Collider other) {
		other.GetComponent<RoomSpawner>().spawned = true;
	}
}
