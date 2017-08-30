using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hawk : Bird {

	public override void Start () {
	base.Start();
	Hunts();	
	}
	// list of things only hawks can do
void Hunts(){
	print(this.name + " Hunts.");
	}
}
