using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {
		List<string> monsters = new List<string>();

	// Use this for initialization
	void Start () {
		monsters.Add("Skeleton");
		monsters.Add("Zombie");
		monsters.Add("Wraith");

		foreach (string i in monsters)
		{
			print(i);
		}


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
