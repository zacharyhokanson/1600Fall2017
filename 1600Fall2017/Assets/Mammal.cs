﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal {
    public override void Start () {
	base.Start();
	LiveBirth();	
	}
    // list of things only mammals can do
void LiveBirth(){
	print(this.name + " Gives live birth.");
	}


}