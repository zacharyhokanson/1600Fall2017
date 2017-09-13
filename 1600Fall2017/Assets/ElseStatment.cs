using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseStatment : MonoBehaviour {

	
	// Update is called once per frame
	public int num1;
	public int num2;
	public int num3;
	public int value;
	public bool canPlay = true;
	public bool playerAlive;
	public bool statusEffect;
	public bool quit;
	public string password = "abcd";

	// Use this for initialization
	void Update () {
		if (num1 + num2 == value)
		{
			print(value);
		} else {
			value = num1 + num2;
		}

		if (canPlay)
		{
			print("Play");
		} else {
			print("Can't Play");
		}

		if (Input.GetKey("w")){
			print("w");
		}
		if (Input.GetKey("d")){
			print("d");
		}
		if (Input.GetKey("s")){
			print("s");
		}
		if (Input.GetKey("a")){
			print("a");
		} else {
			print("Stopped");
		}
		if (num1 != num2){
			print (num1);
		} else {
			print(num3);
		}  
		if (num1 + num2 == value && num1 + num3 == value){
			print(value++);
		} else {
			print(num2);
		}
		if (playerAlive)
		{
			print("Alive");
		} else{
			print("Dead");
		}
		if (num2 != 0)
		{
			value = num1/num2;
			print(value);
		} else{
			print("Can't divide by 0!");
		}
		if (value < 0 && value >10)
		{
			value = 5;
		} else{
			value = value++;
		}
		if (statusEffect)
		{
			print("Injured");
		} else{
			print("Healthy");
		}
		if (num1 == 2)
		{
			
		} else{
			num1 = 2;
		}
		if (quit)
		{
			print("Goodbye");
		} else{
			print("Hello");
		}
	}
}
