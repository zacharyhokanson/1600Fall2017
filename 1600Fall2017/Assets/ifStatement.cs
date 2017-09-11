using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatement : MonoBehaviour {
	public int num1;
	public int num2;
	public int value;

	// Use this for initialization
	void Start () {
		if (num1 + num2 == value)
		{
			print(value);
		}
		
	}
	

}
