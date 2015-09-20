using UnityEngine;
using System.Collections;

public class Pulse2 : MonoBehaviour {
	public float begin2;
	public float end2;
	public float beat2;
	public float startTime;

	// Use this for initialization
	void Start () {
		// Keep a note of the time the movement started.
		startTime = Time.time;
		
		//transform local scale
		transform.localScale = new Vector3(5,begin2,5);
	}
	
	// Update is called once per frame
	void Update () {
		float half = 0.5f;
		var change = (Time.time - startTime);
		var frac = (change/beat2)*(end2 - begin2);
		var frac2 = Mathf.Abs(half-(frac/(end2-begin2)));
		
		if(change < beat2){
			float val = begin2 + 2*frac2*(end2 - begin2);
			transform.localScale = new Vector3(5,val,5);
		}
		else{
			startTime = Time.time;
		}
	}
}
