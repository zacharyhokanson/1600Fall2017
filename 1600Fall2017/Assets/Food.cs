using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

	// Use this for initialization
	public virtual void Start () { //executes fuctions
		Eaten();
	}
	//list of things all animals can do
	void Eaten(){
		print(this.name + " is Eaten."); 
	}



}
