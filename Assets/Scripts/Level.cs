using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
	private static int level = 1;

	public static void next(){
		level++;
		RoomSpawner.resetRoomCount();
		Application.LoadLevel(Application.loadedLevel);
	}

	public static void resetLevel() {
		level = 1;
	}

	public static int getLevel(){
		return level;
	}
}
