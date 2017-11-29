using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {
	public static bool canPlay = true;
	public float gravity = 9.81f;
	public float jumpForce = 150;
	public static int airJump = 2	;
	public int jumps = airJump;
	public float speed = 30;
	public Vector3 moveVector3;
	public CharacterController characterController;
	void Start () {
		
	}
	
	void FixedUpdate () {
		if (canPlay) { // checks if var canPlay is true
			
			if (!characterController.isGrounded){ // checks if player is  not on the ground
				moveVector3.y -= gravity * Time.deltaTime;// applies gravity
			}
			else {
				jumps = airJump; //resets airJump
				moveVector3.y = 0;// Prevents gravity from being calculated
			}
			
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //allows horizontal movement while jumping. 

			if (jumps != 0 && Input.GetKeyDown("space")) { // handles Jumping
				moveVector3.y = jumpForce * Time.deltaTime;
				jumps -= 1;
			}		
			
			// if (characterController.isGrounded){
			// 	airJump = 1;
			// }
			
			characterController.Move(moveVector3);	//applies movement 
		}
	}
		
}
