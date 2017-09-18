using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatments : MonoBehaviour {
	public int cardNumber;
	public char letterGrade;
	// Use this for initialization
	void Start () {
		switch (cardNumber)
		{	
			case 1:
				print("Ace");
				break;
			case 11:
				print("Jack");
				break;
			case 12:
				print("Queen");
				break;
			case 13:
				print("King");
				break;
			
			default:
				print(cardNumber);
				break;
		}
		switch (letterGrade)
		{
			case 'A':
			case 'B':
			case 'C':
				print("Pass");
				break;
			case 'F':
				print("Fail");
				break;

			default:
				print("Invalid Letter Grade");
				break;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
