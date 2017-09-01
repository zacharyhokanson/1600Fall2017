using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle {

  public override void Start () {
	base.Start();
	Parks();	
	}
    // list of things only Cars can do
void Parks(){
	print(this.name + " Parks.");
	}
}
