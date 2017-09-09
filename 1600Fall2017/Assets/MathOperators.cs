using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {
/*Math operators are used to do math operations. Things like + - / * =. 
Anything that does math works as a math operator. */

int x = 4;
int y = 6;
int z = 3;
	// Use this for initialization
	void Start () {
		print(x+y);// Adds x and y
		print(x*y);// Multiplies x and y
		y -= 20;// these operators change and reassign the variable they are placed after. This one subracts 20 to y
		y += 10;// this one adds 10 to y and reassigns y to the new value. 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
