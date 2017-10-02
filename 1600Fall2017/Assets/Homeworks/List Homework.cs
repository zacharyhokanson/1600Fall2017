using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListHomework : MonoBehaviour {
	public List<string> names = new List<string>{"Bob", "Jane", "Bill"};
	// Use this for initialization
	void Start () {
		foreach (string i in names)
		{
			print(i);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
