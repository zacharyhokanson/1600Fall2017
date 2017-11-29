
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

	public Transform player; //defines player
	public NavMeshAgent agent; //defines enemy

	// Update is called once per frame
	void Update () {
		agent.destination = player.position; //sets the enemy's destination to the player
	}
}