using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : Vegetables {

    public override void Start () {
	base.Start();
	GrowUnderGround();	
	}
    // list of things only Carrots can do
void GrowUnderGround(){
	print(this.name + " Grow underground.");
	}
}
