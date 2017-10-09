using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions : MonoBehaviour {
	public int myScore;
	public int health;
	public int ammo;
	public string myPassword = "CoolStuff";
	public List <int> OddNumbers = new List<int>();
	public List <int> EvenNumbers = new List<int>();
	public List<int> Numbers = new List<int>(){50, 75, 24, 13, 89, 100};
	public List <int> PassingGrades = new List<int>();
	public List <int> FailingGrades = new List<int>();
	public int numberPassing;


	// Use this for initialization
	void Start () {
		myScore = ReturnNum(health, ammo);
		myPassword = ReturnPassword(myPassword);
		numberPassing = SortPassing(Numbers);

	}

	int ReturnNum(int _num, int _num2) {
		return _num + _num2;
	}

	string ReturnPassword(string _login){

		if (_login == "ou812")
		{
			return "Password Correct";
		}
		else{
			return "Incorrect";
		}
	}
	void SortEven(List<int> _numbers) {
		foreach (int i in _numbers) //Goes through a list of ints and sorts them into even and odd numbers
		{
			if ( i % 2 == 0)
			{
				//print("Even "+ i);
				EvenNumbers.Add(i); //adds even numbers to even list

			} else{
				//print("Odd " + i);
				OddNumbers.Add(i);//adds odd numbers to odd list
			}
		}
	}
	int SortPassing(List<int> _grades){
		foreach (int i in _grades)
		{
			if (i >= 70)
			{
				PassingGrades.Add(i);
				

			}else{
				FailingGrades.Add(i);
				
			}
		

		}
		return PassingGrades.Count;
	}
}
