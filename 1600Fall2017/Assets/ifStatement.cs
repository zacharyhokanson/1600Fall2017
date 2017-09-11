using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ifStatement : MonoBehaviour {
	// public int num1;
	// public int num2;
	// public int value;
	// public bool canPlay = true;
	public Text input;
	public string password = "abcd";

	// Use this for initialization
	void Update () {
		// if (num1 + num2 == value)
		// {
		// 	print(value);
		// }
		// if (canPlay)
		// {
		// 	print("Play");
		// }
		if (input.text == password){
			print(":D");
		}
	}
}
