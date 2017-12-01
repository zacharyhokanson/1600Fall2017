using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPatrol : MonoBehaviour {

	public Transform[] points;
	public int speed;
	//public Vector3 pointA;
	public Vector3 destination;
	public int index = 0;

	void Start() {
		//UpdateTarget();
		//print(points.Length);
		destination = points[index].position;
	}
	void UpdateTarget(){ //Updates what the current target point is
		if (destination == transform.position) { //if platform is at its destination
			index += 1; 
			if (index > points.Length) { //if index is higher than array length
				index = 0; //reset index to 0
			}
			destination = points[index].position; //set destination to the next point in the array
			
			//print(index); //debug
		}

	}

	void Update() {
		float step = speed * Time.deltaTime;
		UpdateTarget();
		transform.position =  Vector3.MoveTowards(transform.localPosition, destination, step);


	}
 }
