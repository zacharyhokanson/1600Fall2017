﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

	public Image bar;
	public float barTime = 0.1f;

	void OnTriggerEnter () {
		StartCoroutine(UpdateBar());	
	}

	IEnumerator UpdateBar() {
		while (bar.fillAmount < 1){
			bar.fillAmount += barTime;
			yield return new WaitForSeconds(barTime);
		}
	}

}
