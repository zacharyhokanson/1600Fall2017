using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
	public float speed = 10;
	public Vector3 moveVector3;


	void OnTriggerEnter()
	{
		speed *= -1;	
	}

	void FixedUpdate () {
		moveVector3.x = speed * Time.deltaTime;
		transform.Translate(moveVector3);
	}
}
