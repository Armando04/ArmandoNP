using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitCheckpoint : MonoBehaviour {

	public BoxCollider blockWall = null;

	public GameObject blockImageGUI = null;

	private void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			if (blockWall.isTrigger == false) {
				blockImageGUI.SetActive(true);
			}
		}
	}

	private void OnTriggerExit(Collider other) {
		if (other.tag == "Player") {
			Debug.Log("EL jugador ha salido del checkpoint");
			if (blockWall.isTrigger == true) {
				blockWall.isTrigger = false;
			} else {
				blockImageGUI.SetActive(false);
			}
		}
	}
	// Use this for initialization
	//void Start () {}
	
	// Update is called once per frame
	//void Update () {}
}
