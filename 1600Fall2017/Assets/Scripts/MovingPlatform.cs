﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
	public float speed = 10;
	public Vector3 moveVector3;
	// use character controller to handle movement 
	//have check for left and right bounds 
	//public CharacterController characterController;

	void OnTriggerEnter()
	{
		speed *= -1;	
	}

	void FixedUpdate () {
		moveVector3.x = speed * Time.deltaTime;
		transform.Translate(moveVector3);
	}
}
