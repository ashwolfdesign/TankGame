using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {


	// *** TEST SCRIPT ONLY - RENAME AFTER COPY OF COMPONENTS!!!!!!!!!

	Transform player;			// Reference to the player's position.
	//PlayerHealth playerHealth; **Reference to the player's health.
	//EnemyHealth enemyHealth; **Reference to the enemy's health.
	NavMeshAgent nav;			// reference to the nav mesh.


	// Use this for initialization
	void Start (){

	}

	void Awake () {

		// Setup references
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		//playerHealth = player.GetComponent <PlayerHealth> ();
		//enemyhealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <NavMeshAgent> ();

	}

	// Update is called once per frame
	void Update () {

		// Enemy pursuit code


		// If the enemy and the player have health left:
		//if (enemyhealth.currentHealth > 0 && playerHealth.currentHealth > 0) {
			// Set the Destination of the Nav Mesh Agent to the Player
			nav.SetDestination (player.position);

		}

		// Otherwise
		//else {

			//nav.enabled = false;
		}
	


