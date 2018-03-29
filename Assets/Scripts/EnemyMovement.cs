using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    Transform player;
	PlayerHealth enemyHealth;
	NavMeshAgent nav;

	void Start () {
		
	}

	void Awake(){
		player = GameObject.FindGameObjectWithTag("Player").transform;
		PlayerHealth = player.GetComponent<PlayerHealth>();
		nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHealth.currentHealth > 0 && PlayerHealth.currentHealth > 0){
			nav.SetDestination(player.position)
		}else{
            nav.enabled = false;
		}
	}
}
