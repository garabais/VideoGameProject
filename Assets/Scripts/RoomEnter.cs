using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEnter : MonoBehaviour
{
	public RoomData room;
	private void OnTriggerEnter(Collider other) {
		room.enter();
	}
}
