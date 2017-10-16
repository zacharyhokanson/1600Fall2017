﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public float gravity = 9.81f;

	public float jumpForce = 100;
	public float speed = 10;
	public Vector3 moveVector3;
	public CharacterController characterController;
	void Start () {
		
	}
	
	void FixedUpdate () {
		moveVector3.y -= gravity * Time.deltaTime;
		
		if (characterController.isGrounded){
			moveVector3.y += jumpForce * Time.deltaTime;
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;


		}
		
		characterController.Move(moveVector3);	
	}
}