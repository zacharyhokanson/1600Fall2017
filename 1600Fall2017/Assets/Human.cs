using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Mammal {

	public override void Start(){
		base.Start();
		Facebook();
	}
	// list of things only humans can do
	void Facebook (){
		print(this.name + " Facebooks.");
	
	}


}
