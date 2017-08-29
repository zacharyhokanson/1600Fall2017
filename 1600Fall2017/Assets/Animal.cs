using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Dies();
	}
	
	void Dies(){
		print(name + " Dies");
	}

}
