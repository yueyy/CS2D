using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    
	public string weaponName;
	private List<Bullet> bullets;  // 子弹对象数组
	private int bulletCount = 20; // 一个弹夹子弹数
	private int maxBullet = 10; // 预加载子弹数
	private int currentBullet = 0; // 已激活子弹数
    public int shootCount; // 一个弹夹中已打出去的子弹数
	// public float fireRote = 0.2f; // 开火间隔
	// private float currentFireTime; // 当前时间
	public int charger = 5; // 弹夹数

	// public float loadTime = 1.5f;
	// public float currentLoadTime = 0;

	// Use this for initialization
	void Start () {
		InitGun();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")&&checkFire())
		{
			Shot();
		}
	}

    public void InitGun(){
        Bullet weapons = Resources.Load<Bullet> (wraponName);
		if(weapons){
			bullet = new List<Bullet>();
			for(int i = 0; i < maxBullet; i++){
				Bullet bullet = Instantiate(weapons);
				bullet.gameObject.SetActive(false);
				bullet.InitWeapon(transform);
				bullets.Add(bullet);
			}
		}
		weapons = null;
	}

	private bool checkFire(){
        if(charger == 0){
			return true;
		}
		// 当前弹夹有剩余子弹
		if(shootCount < bulletCount){
			return false;
		}

	

		return true;
	}

	private void Shot(){
        if(bullets != null && bullets.Count > 0){
			
		}
	}
}
