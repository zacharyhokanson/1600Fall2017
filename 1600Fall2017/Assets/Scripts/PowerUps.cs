using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour {

	public float powerLevel = 0.1f;
	public float amountToAdd = 0.01f;
	public int coinValue = 10;
	public int score = 0;
	public int totalScore;

	public UIController controller;

	public enum PowerUpType {
		PowerUp, 
		PowerDown,
		Jump,
		Coin
	}
	public PowerUpType powerUp;

	void OnTriggerEnter () {
		switch (powerUp)
		{
			case PowerUpType.PowerUp:
				StartCoroutine(controller.PowerUpBar(powerLevel, amountToAdd));
				break;
			case PowerUpType.PowerDown:
				StartCoroutine(controller.PowerDownBar(powerLevel, amountToAdd));
				break;
			case PowerUpType.Jump:
				CharacterControl.airJump = 3;
				break;
			case PowerUpType.Coin:
				// score++;
				// UIController.ScoreUpdate(score);
				StartCoroutine(CollectCoin());
				break;
		}
	}	

	IEnumerator CollectCoin() {
		totalScore = int.Parse(controller.scoreDisplay.text);
		//UIController.staticScoreDisplay.text = (totalScore + coinValue).ToString();
		int tempAmount = totalScore + coinValue;
		while(totalScore <= tempAmount) {
			controller.scoreDisplay.text = (totalScore++).ToString();
			yield return new WaitForFixedUpdate();
		}
	}
}
