﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

	public Transform player;
	public NavMeshAgent agent;

	// Update is called once per frame
	void Update () {
		agent.destination = player.position;
	}
}