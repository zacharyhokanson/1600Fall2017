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
		ChangeHealth myChangeHealth = gameObject.AddComponent<ChangeHealth>() as ChangeHealth;
		switch (powerUp)
		{
			case PowerUpType.PowerUp:
				myChangeHealth.HealthUp();
				break;
			case PowerUpType.PowerDown:
				myChangeHealth.HealthDown();
				break;
			case PowerUpType.Jump:
				CharacterControl.airJump = 3;
				break;
		}
	}	
}
