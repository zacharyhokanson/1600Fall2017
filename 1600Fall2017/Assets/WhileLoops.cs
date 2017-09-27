using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {
	public int health = 100;
	public int mana = 100;
	public int stamina = 100;
	public bool CanPlay = true;
	public bool Armed = true;

	// Use this for initialization
	void Start () {
		while (true)// while loops, like if staments check for truth. 
		{
			print("True");
		}
		while (false)// if a statment will always be false the code block within it will never been see/used. 
		{
			print("This will never be seen.");
		}
		while (health > 0)// checks if the first value is greater than the second.
		{
			health = health - 1;
			//print(health);
			print("Alive");
		}
		while (mana > 100)
		{
			print("Can cast spells");
		}
		while (stamina > 100 ){
			if (stamina > 50)
			{
				print("Run");
				stamina = stamina - 1;
			}
			if (stamina < 50){ //checks if the first value is les than the second. 
				print("Walk");
				stamina = stamina +1;
			}
		}
		while (CanPlay)
		{
			print("Can Play");
		}
		while (Armed)
		{
			print("Shoot");
		}
		while (health == 100)//compares the two values and checks if the are equal.
		{
			print("Full Health");	
		}
		
		while (health == 100 && mana == 100 && stamina == 100)// && stands for and. it checks if multiple things are true
		{
			print("Full Stats");
		}
		while (health < 50 || mana < 50 || stamina < 50)//|| stands for or. it checks if any one of the things in the statment is true. 
		{
			print("Need to recover.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
