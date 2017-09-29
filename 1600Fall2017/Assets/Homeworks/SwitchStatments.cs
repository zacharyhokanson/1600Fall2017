using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchStatments : MonoBehaviour {
	//public int cardNumber;
	public char letterGrade;
	public Text input;
	public int choice;
	public string[] weapons;
	public int[] i;

	public int x;
	public char character;
	public string stringOne;

	

	public void MyWeaponSwitch(int i) {
		switch (weapons[i])
		{
			case "Missile" :
				print("Missile");
				break;
			case "Plasma" :
				print("Plasma");
				break;
			default:
				print("You have no other weapons.");
				break;
		}
	}

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
		switch (x){ //switch statments can case integers
			case 1:
				print(1);
				break;
			case 2:
				print(2);
				break;
			
			case 3:
				print(3);
				break;

			
			default:
				print("Invalid choice.");
				break;
		}	
		switch (character){ //switch statments can case characters
			case 'a':
				print(character);
				break;
			case 'b':
				print(character);
				break;
			
			case 'c':
				print(character);
				break;

			
			default:
				print("Invalid choice.");
				break;
		}
		switch (stringOne){ //switches can case strings
			case "One":
				print(1);
				break;
			case "Two":
				print(2);
				break;
			
			case "Three":
				print(3);
				break;

			
			default:
				print("Invalid choice.");
				break;
		}
		switch (choice){ //You can nest switch statments, as useless as this one may be 
			case 1:
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
		switch (input.text.ToLower()){ //switch statments could be good for dialouge trees.
			case "Hello":
				print("Nice to meet you.");
				break;
			case "Goodbye":
				print("Have a good day!");
				break;
			default:
				break;
		}
	}
}
