﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vars : MonoBehaviour {
	public float health = 100;
	// Use this for initialization
	void Start () {
		health = 200;
		
	}

		void OnTriggerEnter()
		{
			health = ++health;	
		}
	
	// Update is called once per frame
	void Update () {
			// if (health > 0){
			// 	health -= 0.1f;
			// } else{
			// 	print ("You Died");
			// }
		
	}
}
