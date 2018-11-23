using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterCheckPoint : MonoBehaviour {

	public BoxCollider blockWall = null;

	private void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Debug.Log("EL jugador a entrado en el checkpoint");
			blockWall.isTrigger = true;
		}
	}
	// Use this for initialization
	//void Start () {}
	
	// Update is called once per frame
	//void Update () {}
}
