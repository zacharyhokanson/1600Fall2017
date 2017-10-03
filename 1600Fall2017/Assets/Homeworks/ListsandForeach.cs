using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsandForeach : MonoBehaviour {
	public List<string> Names = new List<string>();//inititalizes and empty list. 
	public List<int> Grades = new List<int>(){50, 75, 24, 13, 89, 100};//initializes the list with item already in it.
	public List <int> OddNumbers = new List<int>();
	public List <int> EvenNumbers = new List<int>();
	public List <int> PassingGrades = new List<int>();
	public List <int> FailingGrades = new List<int>();
	public List<string> Songs = new List<string>(){"Hallelujah", "This Nearly Was Mine", "Style", "Faithfully", "Open Arms"};
	public List<string> Games = new List<string>(){"Halo", "Destiny", "Skyrim"};
	public List<int> ToSort = new List<int>{1,4, 6, 32, 5, 100, 3};
	public List<string> Movies = new List<string>(){"Avatar", "Titanic", "Superman", "Cinderella"};


	// Use this for initialization
	void Start () {
		Names.Add("Bill");//Adds new string to list
		Names.Add("Bob");
		Names.Add("Brad");

		print(Names.Count);// counts how many item are in the list. 

		Games.Insert(1, "Oblivion");//inserts the requested item into the given index of a list
		ToSort.Sort();//Sorts and reorganizes the list  numerically
		Movies.Sort();//Sorts and reorganizes the list alphabetically

		foreach (string i in Names) // Goes through the List and Prints each of the items
		{
			print(i);
		}

		SortEven(Grades);
		SortPassing(Grades);

		foreach (int item in PassingGrades)
		{
			print("Pass " + item + "%");
		}
		foreach (int item in FailingGrades)
		{
			print("Fail " + item + "%");
		}

		if (Names.Contains("Bill"))//checks if given item in within the given list
		{
			print("Names List contains Bill");
		}

		foreach (string item in Songs)
		{
			print(item);
		}

		print(Songs.IndexOf("Style"));//returns the index of the given item potentailly in the list
		print(Songs[1] + " Song 1");
		Songs.RemoveAt(1); //removes the item in the 1 position of the given list
		print(Songs[1] + " Song 1");
	}
	void SortEven(List<int> Numbers) {
		foreach (int i in Numbers) //Goes through a list of ints and sorts them into even and odd numbers
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
		//Numbers.Clear(); //Clears list
	}
	void SortPassing(List<int> Grades){
		foreach (int i in Grades)
		{
			if (i >= 70)
			{
				PassingGrades.Add(i);
			}else{
				FailingGrades.Add(i);
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
