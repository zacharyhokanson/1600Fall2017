using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
	public float hSpeed = 0;
	public float vSpeed = 0;

	public Vector3 moveVector3;


	void OnTriggerEnter(Collider other)
	{
		switch (other.tag){
			case "hBound":
			hSpeed *= -1;
				break;
			case "vBound":
			vSpeed *= -1;
				break;
		}
	}

	void FixedUpdate () {
		moveVector3.x = hSpeed * Time.deltaTime;
		moveVector3.y = vSpeed *Time.deltaTime;
		transform.Translate(moveVector3);
	}
}
