using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemSpawn : MonoBehaviour {
	public GameObject[] collectable;
	public List<int> playerCollected = new List<int>() {};
	public List<int> usedValues = new List<int>() {};
	public List<int> checkedValues = new List<int>() {};
	public int index;
	public int spawns = 3;
	public bool duplicates = true;

	void Start () {
		//collectable[1].SetActive(true);
		GenerateSpawns();
		TurnOnSpawns();
	}
	

	void GenerateSpawns() {
		for (int i = 0; i < spawns * 3; i++) {
			index = Random.Range(0, collectable.Length);
			usedValues.Add(index);
		}
		CheckDuplicates();
	}
	void CheckDuplicates() {
		checkedValues = usedValues.Distinct().ToList();
		while(checkedValues.Count > spawns) {
			checkedValues.RemoveAt(checkedValues.Count-1);
		}
	}
	void TurnOnSpawns(){
		foreach (var item in checkedValues) {
			collectable[item].SetActive(true);
		}

	}
}
