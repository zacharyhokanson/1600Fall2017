using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {
	/*Arrays are used to hold various objects of the same type */
		char[] Grades = new char[4] {'A', 'B', 'C', 'F'};
		int[] Scores = new int[3] {97, 81, 32};
		string[] Response = new string[2]{"Good Job!", "Try Again."};
		string[] Names = new string[3]{"David", "Susan", "Billy"};
		int[] IntTwo = new int[5]{1, 5, 3, 2, 8};
		int[] Stats = new int[3]{12, 16, 48};
		string[] WeaponNames = new string[3]{"Gun", "Missile", "Plasma"};
		string[] AreaNames = new string[3]{"Zone 1", "Zone 2 ", "Zone 3"};
		string[] EnemyNames = new string[2]{"Skeleton", "Zombie"};
		string[] MusicTrakcs = new string[3]{"Track 1", "Track 2", "Track 3"};

	// Use this for initialization
	void Start () {

		GradeScores(Scores);
		PrintStrings(Names);
		PrintInt(IntTwo);
	}
	
	public void GradeScores(int[] x){
		for (int i = 0; i < x.Length; i++)
		{
			if (x[i] >= 90)
			{
				print(Grades[0] + " " + Response[0]);
			} 
			else if (x[i] < 90 && x[i] >= 80)
			{
				print(Grades[1] + " " + Response[0]);
			} 
			else if (x[i] < 80 && x[i] >= 70)
			{
				print(Grades[2] + " " +Response[0]);
			} 
			else
			{
				print(Grades[3] + " " + Response[1]);
			}

		}
	}
	public void PrintStrings(string[] Strings){
		foreach (string i in Strings) //using a for loop you can cyle through the various item in an array.
		{
			print(i);
		}
	}

	public void PrintInt(int[] x){
		foreach (int i in x)
		{
			print(i);
		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
