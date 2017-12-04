using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour {
	public Transform[] collectable;
	public List<int> usedValues = new List<int>() {};
	public HashSet<int> checkValues = new HashSet<int>() {};
	//public bool duplicates = true;
	public int index;
	// Use this for initialization
	void Start () {
		GenerateSpawns();
	}
	

	void GenerateSpawns() {
		for (int i = 0; i < 3; i++) {
			index = Random.Range(0, collectable.Length);
			usedValues.Add(index);
		}
		CheckDuplicates();
		
	}
	void CheckDuplicates() {
		foreach (var item in usedValues) {
			if(!checkValues.Add(item)) {
				print(item + " is a duplicate.");
				print(usedValues[item]);
				usedValues[item] = Random.Range(0, collectable.Length);
				CheckDuplicates();
			}
		}
	}
}
