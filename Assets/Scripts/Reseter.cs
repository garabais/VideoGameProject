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

		RoomSpawner.resetRoomCount();
		if(Input.GetKeyDown(KeyCode.P)){
			Application.LoadLevel(Application.loadedLevel);
		}

		if(Input.GetKeyDown(KeyCode.O)){
			Application.LoadLevel(otherScene);
		}
    }
}
