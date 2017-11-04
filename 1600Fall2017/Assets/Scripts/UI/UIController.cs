using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	public Image bar;
	public GameObject gameOverUI;
	public Text scoreDisplay;

	public IEnumerator PowerUpBar(float _powerLevel, float _amountToAdd) {
			float tempAmount = bar.fillAmount + _powerLevel;
			if (tempAmount > 1) {
				tempAmount = 1;
			}
			while (bar.fillAmount < tempAmount) {
				bar.fillAmount += _amountToAdd;
				yield return new WaitForSeconds(_amountToAdd);
			}
		}
	public IEnumerator PowerDownBar(float _powerLevel, float _amountToAdd) {
		float tempAmount = bar.fillAmount - _powerLevel;
		if (tempAmount < 0) {
			tempAmount = 0;
		}
		while (bar.fillAmount > tempAmount) {
			bar.fillAmount -= _amountToAdd;
		
			yield return new WaitForSeconds(_amountToAdd);

			if (bar.fillAmount == 0) {
				gameOverUI.SetActive(true);
				CharacterControl.gameOver = true;
			}
		}
	}

	public void ScoreUpdate(int _score) {
		scoreDisplay.text = _score.ToString();
	}
}

