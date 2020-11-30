using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reseter : MonoBehaviour
{
	public string otherScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

		if(Input.GetKeyDown(KeyCode.Escape)){
			RoomSpawner.resetRoomCount();
			Level.resetLevel();
			Application.LoadLevel("Menu");
		}
    }
}
