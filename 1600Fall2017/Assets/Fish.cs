﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal {

public override void Start () {
	base.Start();
	Swims();	
	}
	// list of things only fish can do
void Swims(){
	print(this.name + " Swims.");
	}
}