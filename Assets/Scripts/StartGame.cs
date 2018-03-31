using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour {
    public GameObject StartBtn;
	public GameObject QuitBtn;

    void Awake(){
		StartBtn = Canvas.transform.Find("Quick Play").GetComponent<Button>();
		StartBtn.onClick.AddListener(StartPlay);
		QuitBtn = Canvas.transform.Find("Quit").GetComponent<Button>();
        QuickBtn.onClick.AddListener(QuitGame);
	}

    public void StartPlay(){
        // Application.LoadLevel("Game");
		SceneManager.LoadScene("Game");
	}
	
	public void QuitGame(){
		Application.Quit();
	}
}
