using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum checkPointTypes {start, check, end};
public class blockCheckpoint : MonoBehaviour {

	public checkPointTypes checkType;
	public GameObject TimeManager = null;

	private void OnTriggerExit(Collider other) {
		crono internalCrono = null;
		if (other.tag == "Player") {
			internalCrono = TimeManager.GetComponent<crono>();
			if (internalCrono != null) {
				internalCrono.startTimer();
				switch(checkType) {
     				case checkPointTypes.start:
         				internalCrono.startTimer();
         				break;
      				case checkPointTypes.check:
         				//do different stuff
         				break;
					case checkPointTypes.end:
         				//do different stuff
         				break;
				}
			}
		}
	}
	// Use this for initialization
	//void Start () {}
	
	// Update is called once per frame
	//void Update () {}
}
