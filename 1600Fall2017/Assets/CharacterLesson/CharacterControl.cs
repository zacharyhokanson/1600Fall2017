using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public static bool gameOver;
	public float gravity = 9.81f;
	public float jumpForce = 150;
	public int airJump = 1;
	public float speed = 30;
	//add acceleration variable?//
	public Vector3 moveVector3;
	public CharacterController characterController;
	void Start () {
		
	}
	
	void FixedUpdate () {
		if (!gameOver) {
			
			if (!characterController.isGrounded){
				moveVector3.y -= gravity * Time.deltaTime;// **TO FIX** gravity works fine with jumping, not with falling. 
			}
			else {
				airJump = 2;
				moveVector3.y = 0;
			}
			
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //allows horizontal movement while jumping. 

			if (airJump != 0 && Input.GetKeyDown("space")) { // handles Jumping
				moveVector3.y = jumpForce * Time.deltaTime;
				airJump -= 1;
			}		
			
			// if (characterController.isGrounded){
			// 	airJump = 1;
			// }
			
			characterController.Move(moveVector3);	
		}
	}
		
}
