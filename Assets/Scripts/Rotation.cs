using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

	public float moveSpeed = 5;
	public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
		mainCamera = Camera.main;
    }
    // Update is called once per frame
	void Update () {

		// Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);

		// Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

		// float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

		// transform.rotation =  Quaternion.Euler (new Vector3(0f,-1 * angle, 0f));
		//
         Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
         Vector3 moveVelocity = moveInput * moveSpeed;

         Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
         Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
         float rayLength;

         if (groundPlane.Raycast(cameraRay, out rayLength))
         {
             Vector3 pointToLook = cameraRay.GetPoint(rayLength);
             Debug.DrawLine(cameraRay.origin, pointToLook, Color.cyan);

             transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
         }
	}

     float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
     }
}
