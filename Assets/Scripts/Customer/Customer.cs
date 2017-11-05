﻿// Modified code from https://unity3d.com/learn/tutorials/projects/survival-shooter/enemy-one?playlist=17144


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Customer : MonoBehaviour {

	Transform player;               // Reference to the player's position.
	//PlayerHealth playerHealth;      // Reference to the player's health.
	//EnemyHealth enemyHealth;        // Reference to this enemy's health.
	NavMeshAgent nav;               // Reference to the nav mesh agent.
	float customerhealth = 10f;


	void Awake ()
	{
		// Set up the references.
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		//playerHealth = player.GetComponent <PlayerHealth> ();
		//enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <NavMeshAgent> ();
	}

	void Update ()
	{
		// If the enemy and the player have health left...
		//if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
		//	{
		// ... set the destination of the nav mesh agent to the player.
		nav.SetDestination (player.position);
		//	}
		// Otherwise...
		//	else
		//	{
		// ... disable the nav mesh agent.
		//		nav.enabled = false;
		//	}
	} 



	void Fed()
	{
		if (customerhealth <= 0) {
			Destroy (this.gameObject);
		}
	}

}
