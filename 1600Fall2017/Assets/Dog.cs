using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Mammal {

public override void Start () {
	base.Start();
	Barks();	
	}
	// list of things only dogs can do
void Barks(){
	print(this.name + " Barks.");
	}
}
