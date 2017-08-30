using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	public vitrual void Start () {
		Dies();
		Eats();
		Sleeps();
	}
	
	void Dies(){
		print(this.name + " Dies");
	}
	void Eats(){
		print(this.name + " Eats");
	}
	void Sleeps(){
		print(this.name + " Sleeps");
	}

}