using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
	public float speed = 10;
	public Vector3 moveVector3;
	// use character controller to handle movement 
	//have check for left and right bounds 
	public CharacterController characterController;
	void Start () {
		moveVector3.x = speed;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		characterController.Move(moveVector3);
	}
}
