using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchStatments : MonoBehaviour {
	//public int cardNumber;
	public char letterGrade;
	public Text input;
	public int choice;


	// Use this for initialization
	void Start () {
		int cardNumber = Random.Range(1,14);
		//print (random);



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
		switch (choice){
			case 1:
				print("You choose Charmander");
				break;
			case 2:
				print("You choose Squirtle");
				break;
			
			case 3:
				print("You choose Bulbasaur");
				break;

			
			default:
				print("Invalid choice.");
				break;
		}	
	}
	
	// Update is called once per frame
	void Update () {
		switch (input.text.ToLower())
		{
			case "a":
				print("A");
				break;
			case "b":
				print("B");
				break;
			
			default:
				print("Try again");
				break;
		}
		
	}
}
