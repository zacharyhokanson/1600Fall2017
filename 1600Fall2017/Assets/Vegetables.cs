using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegetables : Food {

    public override void Start () {
	base.Start();
	Savory();	
	}
    // list of things only vegetables can do
void Savory(){
	print(this.name + "'s are Savory.");
	}
}
