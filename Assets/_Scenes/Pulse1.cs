using UnityEngine;
using System.Collections;

public class Pulse1 : MonoBehaviour {

	public float begin;
	public float end;
	public float beat;
	public float startTime;

	// Use this for initialization
	void Start () {
		float startTime = Time.time;
		
		//transform local scale
		transform.localScale = new Vector3(begin,begin,begin);
	}
	
	// Update is called once per frame
	void Update () {
		var change = (Time.time - startTime);
		var frac = (change/beat)*(end - begin);
		
		if(change < beat){
			float val = begin + frac*(end-begin);
			transform.localScale = new Vector3(val,val,val);
		}
		else{
			startTime = Time.time;
		}
	}
}
