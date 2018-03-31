using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Camera : MonoBehaviour {

    public Transform target;
	public float smoothing = 5f;
    Vector3 offset;

	void Start () {
		offset = transform.position - target.position;
	}
	
	void Update () {
		
	}

	void FixedUpdate(){
		Vector3 targetCampos = target.position + offset;
		transform.position = Vector3.Lerp(transform.position, targetCampos, smoothing*Time.deltaTime);
		
	}
}
