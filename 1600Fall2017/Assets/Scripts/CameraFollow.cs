﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public Transform player;
	public Vector3 offset;

	void Start() {
		offset.z = -45;
	}
	void LateUpdate() {
		
		transform.position = player.position + offset;
	}
}
