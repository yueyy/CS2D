using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int moveSpeed = 10;
	public int damage = 10;
	public bool isEnmey = true;
	private GameObject player;
	public GameObject enemy;
	

	void Start () {
		// InitGun();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(transform.up * moveSpeed * Time.deltaTime, Space.World);
	    
	}

	private void OnTriggerEnter2D(Collider2D collision){
		switch (collision.tag)
		{
			case "Player":
			    collision.SendMessage("Die");
			    break;
			case "":
			    break;
			case "Enemy":
			    break;
			case "Wall":
			    break;
			case "Barriar":
			    break;
			default:
			    break;
		}
	}

}
