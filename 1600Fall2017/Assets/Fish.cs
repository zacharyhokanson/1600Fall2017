using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal {

public override void Start () {
	base.Swims();	
	}

void Swims(){
	print(this.name + " Swims");
}
}
