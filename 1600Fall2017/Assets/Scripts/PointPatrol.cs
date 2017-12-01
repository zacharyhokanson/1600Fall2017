using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPatrol : MonoBehaviour {

	public Transform[] points;
	public int speed;
	public Vector3 pointA;
	public Vector3 pointB;

	void Start() {
		UpdateTarget();
	}
	void UpdateTarget(){
		pointA = transform.position;
		pointB = points[1].position;

	}

	void Update() {
		float step = speed * Time.deltaTime;
		//transform.position =  Vector3.MoveTowards(pointA, pointB, step);

	}
 }
