using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class utilities : MonoBehaviour {

	public GameObject mainPanel = null;
	public GameObject creditsPanel = null;

	public void ChangeMainScene () {
		SceneManager.LoadScene(1);
	}

	public void ExitGame () {
		Application.Quit();
	}

	public void GotoCredits () {
		mainPanel.SetActive(false);
		creditsPanel.SetActive(true);
	}

	public void GotoMain () {
		creditsPanel.SetActive(false);
		mainPanel.SetActive(true);
	}
	// Use this for initialization
	//void Start () {}
	
	// Update is called once per frame
	//void Update () {}
}
