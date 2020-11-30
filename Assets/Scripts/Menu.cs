using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.Space)){
			RoomSpawner.resetRoomCount();
			Level.resetLevel();
			PlayerDie.resetLifes();
			Application.LoadLevel("Level");
		} else if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
    }

	public void randomSound(){

	}
}
