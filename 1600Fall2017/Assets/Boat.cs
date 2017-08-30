using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : Vehicle {

  public override void Start () {
	base.Start();
	Floats();	
	}
    // list of things only Boats can do
void Floats(){
	print(this.name + " Floats.");
	}
}
