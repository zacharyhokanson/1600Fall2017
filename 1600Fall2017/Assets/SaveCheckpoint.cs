using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCheckpoint : MonoBehaviour {

	Vector3 checkPoint;
	string[] playerPrefsTitles = {"CheckPointX", "CheckPointY", "CheckPointZ"};

	void OnTriggerEnter(){

		checkPoint = transform.position;

		for (int i = 0; i < checkPoint.magnitude; i++)
		{
			PlayerPrefs.SetFloat(playerPrefsTitles[i], checkPoint[i]);
			print(PlayerPrefs.GetFloat(playerPrefsTitles[i]));
		}		
	}



}
