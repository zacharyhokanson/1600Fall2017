using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal {
    public override void Start () {
	base.Start();
	Flies();	
	}
    // list of things only birds can do
void Flies(){
	print(this.name + " Flies.");
	}

}