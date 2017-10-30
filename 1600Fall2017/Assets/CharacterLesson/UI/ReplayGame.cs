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
	public void Click() {
		player.position = startPosition;
		uiBar.fillAmount = fillAmount;
		GameOverUI.SetActive(false);
		CharacterControl.gameOver = false;
	}



}
