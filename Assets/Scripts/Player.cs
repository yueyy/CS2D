using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

      public float moveSpeed = 3;
	public int hp = 100;
	private GameObject bullet;
	private int maxBulletCount = 100;
	private int nowBulletCount = 100;
	private Rigidbody2D rb;
	public GameObject Gun;
	private Vector3 bulletEulerAngles;
	public GameObject Bullet;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		bullet = (GameObject)Resource.Load("Bullet");
	}
	
	void Update () {
	     
	}

	private void FixedUpdate(){
		Move();
		Shoot();
		if(hp <= 0){
			Destroy(this.gameObject);
		}
	}

	private void Move(){
            float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");
		transform.Translate(Vector3.right * h * moveSpeed * Time.deltaTime, Space.World);
		transform.Translate(Vector3.up * v * moveSpeed * Time.deltaTime, Space.World);
		// if(h > 0){
            // bulletEulerAngles = new Vector3(0, 0, -90);
		// }else{
            // bulletEulerAngles = new Vector3(0, 0, +90);
		// }
		// if(v > 0){
            // bulletEulerAngles = new Vector3(0, 0, 0);
		// }else{
            // bulletEulerAngles = new Vector3(0, 0, -180);
		// }
		if(v>0){  //上
			transform.rotation = Quaternion.identity;
		}else if (v<0){
			transform.rotation = Quaternion.Euler (0, 0, -180);
		}
		if (v != 0) {
			return;
		}
		if(h>0){
			transform.rotation =Quaternion.Euler (0, 0, -90);
		}else if (h<0){
			transform.rotation = Quaternion.Euler (0, 0, 90);
		}
	}

	private void Shoot(){
	
	      if(nowBulletCount >= maxBulletCount) { return; }
		if(Input.GetButtonDown("Fire1")){
			nowBulletCount -= 1;
			Instantiate(bullet, transform.position,Quaternion.Euler(transform.eulerAngles));

			// Vector3 direction = Input.mousePosition;
			// GameObject bullet = Instantiate(Bullet,Spwan.transform.position, Quaternion.identity) as GameObject;

			// Instantiate(bullet,transform.position,Quaternion.EulerAngles(transform.eulerAngles + bulletEulerAngles));
		}
	}

	private void OnTriggerEnter2D(Collider2D other) {
		switch (other.gameObject.tag)
		{
		    case "Bullet":
		         hp -= 10;
			   break;
		    default:
		         break;
		}
	}

	void ChangeGun(){	
           

	}
}
