using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crono : MonoBehaviour {

	public Text timerText = null;
	//public int checkpointCount = 0;
	public float[] checkpointTimeList;
	private float startTime = 0.0f;
	private float raceTime = 0.0f;
	private bool keepTiming = false;
	public void startTimer () {
		keepTiming = true;
		startTime = Time.time;
	}

	public void checkpoitTimer (int checkpointIndex) {
		if ((checkpointIndex > 0) && (checkpointIndex < checkpointTimeList.Length)) {
			checkpointTimeList[checkpointIndex] = raceTime;
		}
	}

	public float stopTimer () {
		keepTiming = false;
		return raceTime;
	}

	public string TimeToString(float t){
         string minutes = ((int) t / 60).ToString();
         string seconds = (t % 60 ).ToString("f2");
         return minutes + ":" + seconds;
     }
	// Use this for initialization
	void Start () {
		keepTiming = false;
		startTime = 0.0f;
		raceTime = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (keepTiming) {
			raceTime = Time.time - startTime;
        	timerText.text = TimeToString(raceTime);
		}
	}
}
 