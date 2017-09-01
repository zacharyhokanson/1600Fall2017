using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Fruit {

    public override void Start () {
	base.Start();
	GrowInTrees();	
	}
    // list of things only bananas can do
void GrowInTrees(){
	print(this.name + " Grow in trees.");
	}
}
