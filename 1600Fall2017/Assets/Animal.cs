using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	public virtual void Start () { //executes fuctions
		Eats();
		Sleeps();
		Dies();
	}
	//list of things all animals can do
	void Dies(){
		print(this.name + " Dies."); 
	}
	void Eats(){
		print(this.name + " Eats.");
	}
	void Sleeps(){
		print(this.name + " Sleeps.");
	}

}