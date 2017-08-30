using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : Mammal {
	public override void Start () {
	base.Start();
	Sings();	
	}
	// list of things only whales can do
void Sings(){
	print(this.name + " Sings.");
	}
}
