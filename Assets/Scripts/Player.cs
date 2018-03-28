using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed = 3;
	public GameObject bullet;

	void Start () {
		
	}
	
	void Update () {
		
	}

	private void FixedUpdate(){
		Move();
		Attack();
	}

	private void Move(){
        float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");
		transform.Translate(Vector3.right * h * moveSpeed * Time.deltaTime, Space.World);
		transform.Translate(Vector3.up * v * moveSpeed * Time.deltaTime, Space.World);
	}

	private void Attack(){
		// bullet = GameObject.Find("Bullet");
		// if (Input.GetButtonDown("Fire1"))
		// {
		// 	var mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		// 	var n = Instantiate(bullet,transform.position, transform.rotation);
		// 	n.GetComponent<Rigidbody>().AddForce(mouseRay.direction * 3000);
		// }
		if(Input.GetButtonDown("Fire1")){
			Instantiate(bullet,transform.position,transform.rotation);
			
		}
		
	}
}
