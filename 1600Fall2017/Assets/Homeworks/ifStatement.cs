﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ifStatement : MonoBehaviour {
	public int num1;
	public int num2;
	public int num3;
	public int value;
	public bool canPlay = false;
	public Text input;
	public string password = "abcd";

	// Use this for initialization
	void Update () {
		// if (num1 + num2 == value)
		// {
		// 	print(value);
		// }
		if (canPlay)
		{
			print("Play");
		} else{
			print("Can't Play");
		}
		if (input.text == password){
			print("Welcome");
			canPlay = true;
		} else {
			print("Incorrect Password");
			canPlay = false;
		}
		// if (Input.GetKey("w")){
		// 	transform.Translate(0, .1f, 0);
		// }
		// if (Input.GetKey("d")){
		// 	transform.Translate(.1f, 0, 0);
		// }
		// if (Input.GetKey("s")){
		// 	transform.Translate(0, -.1f, 0);
		// }
		// if (Input.GetKey("a")){
		// 	transform.Translate(-.1f, 0, 0);
		// }
		// if (num1 != num2){
		// 	print (num1);
		// }   
		// if (num1 + num2 == value & num1 + num3 == value){
		// 	print(value++);
		// }
		// if(num1 == value | num2 == value){
		// 	print(num3);

		// }
	}
}
