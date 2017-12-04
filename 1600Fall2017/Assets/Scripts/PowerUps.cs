using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour {
	// variables define basic values for PowerUp types
	public float powerLevel = 0.1f;
	public float amountToAdd = 0.01f;
	public int coinValue = 10;
	public bool hit = false;
	public UIController controller; //allows access to UIController script

	public enum PowerUpType { //stores types of PowerUps
		PowerUp, 
		PowerDown,
		Jump,
		Coin,
		LevelWon,


	}
	public PowerUpType powerUp;
	void OnTriggerEnter() {//checks for powerup type
		switch (powerUp)
		{
			case PowerUpType.PowerUp:
				if(!hit){
				StartCoroutine(controller.PowerUpBar(powerLevel, amountToAdd));//runs Coroutine in UIController script
				StartCoroutine(PowerUpInactive());
				GetComponent<MeshRenderer>().enabled = false;
				hit = true;
				//gameObject.SetActive(false);
				}
				
				break;
			case PowerUpType.PowerDown:
				StartCoroutine(controller.PowerDownBar(powerLevel, amountToAdd));//runs Coroutine in UIController script
				break;
			// case PowerUpType.Jump:  **Work On, needs to reset airJump to the regular value after use**
			// 	CharacterControl.airJump = 3;
			// 	break;
			case PowerUpType.Coin:
				if(!hit){
				StartCoroutine(controller.CollectCoin(coinValue));//runs Coroutine in UIController script
				StartCoroutine(PowerUpInactive());
				GetComponent<MeshRenderer>().enabled = false;
				hit =  true;
				}
				
				break;
			case PowerUpType.LevelWon:
				//CharacterControl.canPlay = false;
				controller.EndGame("You Win!", "Next Level");//runs UIController EndGame function
				//controller.levelUI.SetActive(true);
				break;


		}
	}	
public IEnumerator PowerUpInactive(){
	
	yield return new WaitForSeconds(1);
	gameObject.SetActive(false);
}

	
}
