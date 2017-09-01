using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour {

	// Use this for initialization
	public virtual void Start () { //executes fuctions
		Transports();
		Drives();
	}
	//list of things all Vehicles can do
	void Drives(){
		print(this.name + " Drives."); 
	}
	void Transports(){
		print(this.name + " Transports.");
	}
}
