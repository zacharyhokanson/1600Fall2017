using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHealth : MonoBehaviour {
	public Image bar;
	public GameObject gameOverUI;
	public float powerLevel = 0.1f;
	public float amountToAdd = 0.01f;
	public void HealthUp() {
		StartCoroutine(PowerUpBar());
	}
	public void HealthDown(){
		StartCoroutine(PowerDownBar());
	}
	public IEnumerator PowerUpBar() {
			float tempAmount = bar.fillAmount + powerLevel;
			if (tempAmount > 1) {
				tempAmount = 1;
			}
			while (bar.fillAmount < tempAmount) {
				bar.fillAmount += amountToAdd;
				yield return new WaitForSeconds(amountToAdd);
			}
		}
	public IEnumerator PowerDownBar() {
		float tempAmount = bar.fillAmount - powerLevel;
		if (tempAmount < 0) {
			tempAmount = 0;
		}
		while (bar.fillAmount > tempAmount) {
			bar.fillAmount -= amountToAdd;
		
			yield return new WaitForSeconds(amountToAdd);

			if (bar.fillAmount == 0) {
				gameOverUI.SetActive(true);
				CharacterControl.gameOver = true;
			}
		}
	}
}

