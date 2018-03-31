using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shoot : MonoBehaviour {
    
	public string weaponName;
	private Rigidbody2D rb;

	private GameObject bullet;
	private int bulletCount = 20; // 一个弹夹子弹数
	public int damage = 10; // 一个子弹的伤害
    private GameObject player;
	private GameObject enemy;
	public bool IS_PLAYER_BULLET = false;
	private float MoveSpeed = 8f;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		Vector3 v3 = transform.up.normalized;
		rb.velocity = v3 * MoveSpeed;

		if (IS_PLAYER_BULLET == true){
			player = GameObject.FindObjectWithTag("Player");
		}
	}
	
	void Update () {
		if (Input.GetButton("Fire1"))
		{
			Shoot();
		}
	}

    // public void InitGun(){
    //     bullet =(GameObject) Resources.Load("bullet");
		
	// }

	// private bool checkFire(){
    //     if(charger == 0){
	// 		return true;
	// 	}
	// 	// 当前弹夹有剩余子弹
	// 	if(shootCount < bulletCount){
	// 		return false;
	// 	}
	// 	return true;
	// }

// 更新子弹数量
    private void updateNowBulletCount(){
		if(player != null){
			int tempCount = player.GetComponent<Player>().nowBulletCount;
			if(tempCount > 0){
				player.GetComponent<Player>().nowBulletCount -= 1;
			}
		}
	}


	/// <summary>
	/// 碰撞检测
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		if(IS_PLAYER_BULLET == true){
			switch (other.tag)
			{
				case "Enemy":
				    this.gameObject.hp -= 10;
					break;
				case "brick":
				    Destroy(other.gameObject);
					updateNowBulletCount();
					
					break;

				default:
				    break;
			}
		}else{
			switch(other.tag){
				case "Player":
				    
					break;
				case "brick":
				    
					break;

				default:
				    break;
			}
		}
	}
}
