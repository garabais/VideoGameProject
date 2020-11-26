using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
	public int openingDirection;
	// 1 --> need bottom door
	// 2 --> need top door
	// 3 --> need left door
	// 4 --> need right door

	public float waitTime = 4f;
	private int rand;
	public bool spawned = false;

	private static RoomTemplate templates;
	private static int rooms;
	private static bool hasBoss = false;
	public static int MAX_ROOMS = 255;
	private GameObject room;

    // Start is called before the first frame update
    void Start()
    {
		Destroy(gameObject, waitTime);
		if (templates == null) {
			templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplate>();
		}
		Invoke("Spawn", 0.1f);
    }

	void Spawn(){
		if(spawned == false){
			if(rooms > MAX_ROOMS) {
				room = templates.emptyRoom;
			}else if(openingDirection == 1){
				// Need to spawn a room with a BOTTOM door.
				rand = Random.Range(0, templates.bottomRooms.Length);
				room = templates.bottomRooms[rand];
				if(!hasBoss && room.tag == "FinalRoom") {
					hasBoss = true;
					room = templates.bossB;
				}
				// Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
			} else if(openingDirection == 2){
				// Need to spawn a room with a TOP door.
				rand = Random.Range(0, templates.topRooms.Length);
				room = templates.topRooms[rand];
				if(!hasBoss && room.tag == "FinalRoom") {
					hasBoss = true;
					room = templates.bossT;
				}
				// Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
			} else if(openingDirection == 3){
				// Need to spawn a room with a LEFT door.
				rand = Random.Range(0, templates.leftRooms.Length);
				room = templates.leftRooms[rand];
				if(!hasBoss && room.tag == "FinalRoom") {
					hasBoss = true;
					room = templates.bossL;
				}
				// Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
			} else if(openingDirection == 4){
				// Need to spawn a room with a RIGHT door.
				rand = Random.Range(0, templates.rightRooms.Length);
				room = templates.rightRooms[rand];
				if(!hasBoss && room.tag == "FinalRoom") {
					hasBoss = true;
					room = templates.bossR;
				}
				// Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
			}
			Instantiate(room, transform.position, room.transform.rotation);
			rooms++;
			spawned = true;
		}
	}

	private void OnTriggerEnter(Collider other) {
		if(other.CompareTag("RoomSpawnPoint")){
			if(other.GetComponent<RoomSpawner>().spawned == false && spawned == false){
				if(!hasBoss){
					if(openingDirection == 1){
						hasBoss = true;
						room = templates.bossB;
					} else if(openingDirection == 2){
						hasBoss = true;
						room = templates.bossT;
					} else if(openingDirection == 3){
						hasBoss = true;
						room = templates.bossL;
					} else if(openingDirection == 4){
						hasBoss = true;
						room = templates.bossR;
					}
				} else{
					room = templates.emptyRoom;
				}
				Instantiate(room, transform.position, room.transform.rotation);
				Destroy(gameObject);
			}
			spawned = true;
		}
	}

	public static void resetRoomCount(){
		rooms = 0;
		hasBoss = false;
	}
}
