using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {
/*Math operators are used to do math operations. Things like + - / * =. 
Anything that does math works as a math operator. */

public float x = 4;
public float y = 6;
public float z = 3;
public float a;
public float b;
public float c;
public float num1 = 15;
public float num2 = 6;
public float remainderResult;
public int DivOne = 0;
public int DivTwo = 1;


	// Use this for initialization
	void Start () {
		// print(x+y);// Adds x and y
		// print(x*y);// Multiplies x and y
		// y -= 20;// these operators change and reassign the variable they are placed after. This one subracts 20 to y.
		// y += 10;// this one adds 10 to y and reassigns y to the new value. 
		// y += x; // this one adds x to y and reasigns y to the new value. 
		// y = ++y;// this adds one to y and then reasigns the new value to y... adds before assignment.
		// y = y++;// this assins y to y and then adds one to y... adds affter assignment.
		a = y -= x;// assigns a to the value of y - x
		print(a);
		remainderResult = num1 % num2;//modulus(%) gives the remainder of a division operation. 15/6 = 2 R 3, give the 3 value. 
		print(remainderResult);
		if(DivTwo!=0){// checks to make sure not dividing by 0
			b = DivOne/DivTwo;
			print(b);
		} else {
			print("Can't Divide By 0");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
