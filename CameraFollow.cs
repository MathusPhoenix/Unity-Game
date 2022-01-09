using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	
	// Transform is used to determine the Position, Rotation, and Scale of each object in the scene. Every GameObject has a Transform.
	private Transform playerTransform;
	// Player
	public GameObject ball;
	
	// Start is called before the first frame update
	void Start() {
		playerTransform = ball.transform;
	}

	// LateUpdate is called after all Update() method are processed.
	void LateUpdate() {
		// store current camera's position in temp
		Vector3 temp = transform.position;
		
		// set camera's x axis to player's x axis
		temp.x = playerTransform.position.x;
		temp.y = playerTransform.position.y;
		
		// transform camera position to player position.
		transform.position = temp;
	}
}
