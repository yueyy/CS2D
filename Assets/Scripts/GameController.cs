using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public Text shownessage;

	void Start () {
		
	}
	
	void Update () {
		
	}

	public void OnLoginButtonClick(){
		SceneManager.LoadScene(1);
	}

	IEnumerator DisappearMessage(){
		yield return new WaitForSeconds(1);
		shownessage.gameObject.SetActive(false);
	}
}
