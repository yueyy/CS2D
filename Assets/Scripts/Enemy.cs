using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float moveSpeed = 3;
	public int hp = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}

	private virtual void Move(){
        Vector3 tempPos = pos;
		tempPos.y -= moveSpeed * Time.deltaTime;
		pos = tempPos;
	}
 
    void OnCollisionEnter(Collection coll){
		GameObject other = coll.gameObject;
		switch (other.tag)
		{
			case "Player":
			    
			    break;
			case "Enemy":
			    Destory(this.gameObject);
				break;
			default:
			    break;
		}
	}

	public Vector3 pos{
		get {
			return (this.tranform.position);
		}
		set {
			this.tranform.position = value;
		}
	}
	
}
