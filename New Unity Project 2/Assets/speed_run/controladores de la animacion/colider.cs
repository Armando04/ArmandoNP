using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colider : MonoBehaviour {

public GameObject InternalAnimedDoor = null;

private Animator _Internalanimator = null;

private void OnTriggerEnter(Collider other) {
	if (other.tag == "Player") {
		_Internalanimator.SetBool("opened", true);
	}
}

	// Use this for initialization
	void Start () {
		_Internalanimator = InternalAnimedDoor.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
