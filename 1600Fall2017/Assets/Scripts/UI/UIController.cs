using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	public Image bar;
	public GameObject gameOverUI;
	public Text scoreDisplay;

	public static Image staticBar;
	public static GameObject staticGameOverUI;
	public static Text staticScoreDisplay;


	void Start() {
		staticBar = bar;
		staticGameOverUI = gameOverUI;
		staticScoreDisplay = scoreDisplay;
	}
	public static IEnumerator PowerUpBar(float _powerLevel, float _amountToAdd) {
			float tempAmount = staticBar.fillAmount + _powerLevel;
			if (tempAmount > 1) {
				tempAmount = 1;
			}
			while (staticBar.fillAmount < tempAmount) {
				staticBar.fillAmount += _amountToAdd;
				yield return new WaitForSeconds(_amountToAdd);
			}
		}
	public static IEnumerator PowerDownBar(float _powerLevel, float _amountToAdd) {
		float tempAmount = staticBar.fillAmount - _powerLevel;
		if (tempAmount < 0) {
			tempAmount = 0;
		}
		while (staticBar.fillAmount > tempAmount) {
			staticBar.fillAmount -= _amountToAdd;
		
			yield return new WaitForSeconds(_amountToAdd);

			if (staticBar.fillAmount == 0) {
				staticGameOverUI.SetActive(true);
				CharacterControl.gameOver = true;
			}
		}
	}

	public static void ScoreUpdate(int _score) {
		staticScoreDisplay.text = _score.ToString();
	}
}

