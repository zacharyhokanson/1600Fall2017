using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal {
    public override void Start () {
	base.Start();
	Flies();	
	}

void Flies(){
	print(this.name + " Flies.");
	}

}