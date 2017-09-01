using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : Food {

    public override void Start () {
	base.Start();
	Sweet();	
	}
    // list of things only Fruts can do
void Sweet(){
	print(this.name + " is Sweet.");
	}
}
