using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayGame : MonoBehaviour {

	public Transform player;
	public Image uiBar;
	public GameObject GameOverUI;
	public static Vector3 startPosition;
	private float fillAmount;

	public void Awake() {
		GameOverUI.SetActive(false);
		startPosition = player.position;
		fillAmount = uiBar.fillAmount;
	}
	public void Click() { //when button is clicked
		player.position = startPosition;//reset player position to the startPosition
		uiBar.fillAmount = fillAmount;//reset health bar to initial fill level
		GameOverUI.SetActive(false);//Turn of UI
		CharacterControl.canPlay = true;//Tell CharacterControl that canPlay is true
	}



}
