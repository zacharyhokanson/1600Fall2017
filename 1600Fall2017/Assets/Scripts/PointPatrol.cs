using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPatrol : MonoBehaviour {

	public Transform[] points;
	public int speed;
	//public Vector3 pointA;
	public Vector3 destination;
	public int index = 0;
	public enum PlatformType
	{
		Line,
		Cycle
	}
	public PlatformType platformType;
	void Start() {
		destination = points[index].position;
	}
	void UpdateTarget(){
		if (destination == transform.position) { //if platform is at its destination
				index ++; 
				if (index >= points.Length) { //if index is higher than array length
					if(platformType == PlatformType.Line) {
						System.Array.Reverse(points);
					}
					index = 0;
				}
				destination = points[index].position; //set destination to the next point in the array
		}
	}
	void Update() {
		float step = speed * Time.deltaTime;
		UpdateTarget();
		transform.position =  Vector3.MoveTowards(transform.localPosition, destination, step);// moves object
	}
 }
