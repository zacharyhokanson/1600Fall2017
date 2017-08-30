using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : Mammal {
	public override void Start () {
	base.Start();
	Sings();	
	}

void Sings(){
	print(this.name + " Sings.");
	}
}
