using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour {

	public float powerLevel = 0.1f;
	public float amountToAdd = 0.01f;

	public enum PowerUpType {
		PowerUp, 
		PowerDown,
		Jump
	}
	public PowerUpType powerUp;

	void OnTriggerEnter () {
		switch (powerUp)
		{
			case PowerUpType.PowerUp:
				StartCoroutine(ChangeHealth.PowerUpBar(powerLevel, amountToAdd));
				break;
			case PowerUpType.PowerDown:
				StartCoroutine(ChangeHealth.PowerDownBar(powerLevel, amountToAdd));
				break;
			case PowerUpType.Jump:
				CharacterControl.airJump = 3;
				break;
		}
	}	
}
