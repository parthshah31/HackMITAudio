using UnityEngine;
using System;

/*
 * Make your class implement the interface AudioProcessor.AudioCallbaks
 */
public class Example : MonoBehaviour, AudioProcess.AudioCallbacks
{
	
	void Start()
	{
		//Select the instance of AudioProcessor and pass a reference
		//to this object
		AudioProcess processor = FindObjectOfType<AudioProcess>();
		processor.addAudioCallback(this);
	}
	
	
	void Update()
	{
		
	}
	
	//this event will be called every time a beat is detected.
	//Change the threshold parameter in the inspector
	//to adjust the sensitivity
	public void onOnbeatDetected()
	{
		AudioProcess processor = FindObjectOfType<AudioProcess>();
		processor.changeCameraColor();
	}
	
	//This event will be called every frame while music is playing
	public void onSpectrum(float[] spectrum)
	{
		//The spectrum is logarithmically averaged
		//to 12 bands
		
		for (int i = 0; i < spectrum.Length; ++i)
		{
			Vector3 start = new Vector3(i, 0, 0);
			Vector3 end = new Vector3(i, spectrum[i], 0);
			Debug.DrawLine(start, end);
		}
	}
}