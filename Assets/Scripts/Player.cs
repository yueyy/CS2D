using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed = 3;
	public int hp = 100;
	private Vector3 bulletEulerAngles;
	public GameObject bullet;

	void Start () {
		
	}
	
	void Update () {
		
	}

	private void FixedUpdate(){
		Move();
		Shoot();
	}

	private void Move(){
        float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");
		transform.Translate(Vector3.right * h * moveSpeed * Time.deltaTime, Space.World);
		transform.Translate(Vector3.up * v * moveSpeed * Time.deltaTime, Space.World);
		if(h > 0){
            bulletEulerAngles = new Vector3(0, 0, -90);
		}else{
            bulletEulerAngles = new Vector3(0, 0, +90);

		}

		if(v > 0){
            bulletEulerAngles = new Vector3(0, 0, 0);

		}else{
            bulletEulerAngles = new Vector3(0, 0, -180);

		}
	}

	private void Shoot(){
	
		if(Input.GetButtonDown("Fire1")){
			Instantiate(bullet,transform.position,Quaternion.EulerAngles(transform.eulerAngles + bulletEulerAngles));
		}
	}

	private void Die(){
		// Destory(gameObject);
	}
}
