using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	public Image bar;
	public GameObject levelUI;
	public Text levelOverText;
	public Text scoreDisplay;
	public Text buttonText;
	public int score = 0;
	public int totalScore;

	public IEnumerator PowerUpBar(float _powerLevel, float _amountToAdd) {//Coroutine for adding to Health Bar
			float tempAmount = bar.fillAmount + _powerLevel;
			if (tempAmount > 1) {
				tempAmount = 1;
			}
			while (bar.fillAmount < tempAmount) {
				bar.fillAmount += _amountToAdd;
				yield return new WaitForSeconds(_amountToAdd);
			}
		}
	public IEnumerator PowerDownBar(float _powerLevel, float _amountToAdd) {//Coroutine for subtracting from Healt Bar
		float tempAmount = bar.fillAmount - _powerLevel;
		if (tempAmount < 0) {
			tempAmount = 0;
		}
		while (bar.fillAmount > tempAmount) {
			bar.fillAmount -= _amountToAdd;
		
			yield return new WaitForSeconds(_amountToAdd);

			if (bar.fillAmount == 0) {//if Health goes to zero End Game
				EndGame("GAME OVER", "Replay");
				
				
			}
		}
	}
	public IEnumerator CollectCoin(int _coinValue) {//Coroutine for adding points to the score from coins 
		totalScore = int.Parse(scoreDisplay.text);
		int tempAmount = totalScore + _coinValue;
		while(totalScore <= tempAmount) {
			scoreDisplay.text = (totalScore++).ToString();
			yield return new WaitForFixedUpdate();

		}
	}

	public void EndGame(string _levelText, string _buttonText) {// EndGame Function takes aguments for end screen and button text
		//levelOverText.alignment = TextAnchor.UpperCenter;
		levelOverText.text = _levelText;// sets end screen text
		//buttonText.alignment = TextAnchor.MiddleCenter;
		buttonText.text = _buttonText;// sets button text
		levelUI.SetActive(true);//brings up the UI screen
		CharacterControl.canPlay = false;//tells CharacterControl canPlay is false 

	}
	// public void ScoreUpdate(int _score) {
	// 	scoreDisplay.text = _score.ToString();
	// }
}

