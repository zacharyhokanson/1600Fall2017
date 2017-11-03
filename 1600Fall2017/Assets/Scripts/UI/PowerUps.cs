using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour {

	// public Image bar;
	// public GameObject gameOverUI;

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
				ChangeHealth.HealthUp();
				break;
			case PowerUpType.PowerDown:
				ChangeHealth.HealthDown();
				break;
			case PowerUpType.Jump:
				CharacterControl.airJump = 3;
				break;
		}
	}	
}
