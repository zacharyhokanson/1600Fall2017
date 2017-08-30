using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingBoat : Boat {

  public override void Start () {
	base.Start();
	Fishes();	
	}
    // list of things only Fishingboats can do
void Fishes(){
	print(this.name + " Fishes.");
	}
}
