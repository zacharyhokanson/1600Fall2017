using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions : MonoBehaviour {
	public int myScore;
	public int health;
	public int ammo;
	public string myPassword = "CoolStuff";
	public List <int> oddNumbers = new List<int>();
	public List <int> evenNumbers = new List<int>();
	public List<int> numbers = new List<int>(){50, 75, 24, 13, 89, 100};
	public List <int> passingGrades = new List<int>();
	public List <int> failingGrades = new List<int>();
	public int numberPassing;
	public int sortedEvens;
	public int x = 0;
	public int z = 0;
	public string playerName = "Steve";



	// Use this for initialization
	void Start () {
		myScore = ReturnNum(health, ammo);
		myPassword = ReturnPassword(myPassword);
		numberPassing = SortPassing(numbers);
		sortedEvens = SortEven(numbers);
		x = AddNumbers();
		print(PrintNameSentance(playerName));
		z = PrintForLoop();

	}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	int SortEven(List<int> _numbers) {
		foreach (int i in _numbers) //Goes through a list of ints and sorts them into even and odd numbers
		{
			if ( i % 2 == 0)
			{
				//print("Even "+ i);
				evenNumbers.Add(i); //adds even numbers to even list

			} else{
				//print("Odd " + i);
				oddNumbers.Add(i);//adds odd numbers to odd list
			}
		}
		return evenNumbers.Count;
	}

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
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
	int SortPassing(List<int> _grades){
		foreach (int i in _grades)
		{
			if (i >= 70)
			{
				passingGrades.Add(i);
				

			}else{
				failingGrades.Add(i);
				
			}
		

		}
		return passingGrades.Count;
	}

	int AddNumbers(){

		for (int i = 0; i < 10; i++)
		{
			x = x + 1;
		}
		return x;
	}
	
	string PrintNameSentance(string _name){
		string z;
		z = string.Format("Hello {0}!", _name);
		return z;
	}
	int PrintForLoop(){
		int timesCounted = 0;
		for (int i = 0; i < 12; i++)
		{
			print ("Hello");
			timesCounted++;
		}
		return timesCounted;
	}
	int MultiplyNumbers(int _n){
		for (int i = 0; i < 10; i++)
		{
			_n = _n*3;
		}
		return _n;
	}
	int DivideNumbers(int _n){
		for (int i = 0; i < 12; i++)
		{
			_n = _n/2;
		}
		return _n;
	}
	int ComplexMulitply(int _n, int _t){ //takes arguemnts _n number and _t times
		for (int i = 0; i < _t; i++)//multiplies _n by 2 _t times.
		{
			_n = _n *2;
		}
		return _n;
	}
}
