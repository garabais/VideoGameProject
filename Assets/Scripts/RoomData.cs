using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomData : MonoBehaviour
{
	public GameObject[] doors;
	public GameObject[] entrances;
	public GameObject[] spawners;
	public GameObject exit;

	public void enter(){
		foreach(GameObject entrance in entrances) {
			Destroy(entrance);
		}
		if (spawners.Length != 0) {
			foreach(GameObject spawn in spawners) {
				spawn.active = true;
			}
			foreach(GameObject door in doors) {
				door.active = true;
			}
		} else {
			foreach(GameObject door in doors) {
				Destroy(door);
			}
		}
		if( exit != null ){
			exit.active = true;
		}
	}
}
