using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour {

	public float powerLevel = 0.1f;
	public float amountToAdd = 0.01f;
	public int coinValue = 10;
	

	public UIController controller;

	public enum PowerUpType {
		PowerUp, 
		PowerDown,
		Jump,
		Coin,
		LevelWon
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
				StartCoroutine(controller.CollectCoin(coinValue));
				break;
			case PowerUpType.LevelWon:
				CharacterControl.gameOver = true;
				controller.ChangeText("You Win!", "Next Level");
				controller.levelUI.SetActive(true);
				break;
		}
	}	

	
}
