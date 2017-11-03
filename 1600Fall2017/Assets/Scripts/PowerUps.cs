using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour {

	public float powerLevel = 0.1f;
	public float amountToAdd = 0.01f;
	public int score = 0;

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
				StartCoroutine(UIController.PowerUpBar(powerLevel, amountToAdd));
				break;
			case PowerUpType.PowerDown:
				StartCoroutine(UIController.PowerDownBar(powerLevel, amountToAdd));
				break;
			case PowerUpType.Jump:
				CharacterControl.airJump = 3;
				break;
			case PowerUpType.Coin:
				score++;
				scoreDisplay.text = score.ToString();
				break;
		}
	}	
}
