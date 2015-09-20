using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngineInternal;

public class Main : MonoBehaviour {

	//List<object> objects = new List<object>();
	public static List<int> type = new List<int>();
	public static List<GameObject> objects = new List<GameObject> ();
	public static float index = -1;

	

	public static void createObject(int ObjectType, float startSize, float finalSize, float beatCount){
		Debug.Log ("createObject() Called");
		type.Add(ObjectType);
		index++;

		GameObject sphere = GameObject.Find("Sphere");
		GameObject cylinder = GameObject.Find ("Cylinder");
		GameObject beatsObj = GameObject.Find("Audio1 Beat");
		AudioSource beats = beatsObj.GetComponent<AudioSource>();
		float pitch = beats.pitch;

		beatCount = beatCount / pitch;


		//print (System.Type.GetType("Pulse"));

		//add stopPulse and startPulse senders 

		//get coordinates for the new object

		float x = 0;
		float y = 0;
		float z = 15*index;

		Pulse1 scriptref;
		Pulse2 scriptref2;

		if (ObjectType == 0) {
			GameObject tempObj = Instantiate(sphere);
			tempObj.transform.position = new Vector3(x,y,z);
			tempObj.transform.localScale = new Vector3(finalSize,finalSize,finalSize);
			scriptref = tempObj.GetComponent<Pulse1>();
			scriptref.end = finalSize;
			scriptref.beat = beatCount;
			scriptref.begin = startSize;

			objects.Add(tempObj);
		}

		if (ObjectType == 1) {
			GameObject tempObj = Instantiate (cylinder);
			tempObj.transform.position = new Vector3(x,y,z);
			tempObj.transform.localScale = new Vector3(finalSize,finalSize,finalSize);
			scriptref2 = tempObj.GetComponent<Pulse2>();
			scriptref2.end2 = finalSize;
			scriptref2.beat2 = beatCount;
			scriptref2.begin2 = startSize;

			objects.Add(tempObj);
		}

		//create the object
		//if (ObjectType == 0) {
			//GameObject tempObj = Instantiate (GameObject ObjectType1, Vector3(Matrix4x4,y,z),Quaternion.
			//GameObject tempObj = GameObject.CreatePrimitive(PrimitiveType.Sphere) as GameObject;
			//tempObj.transform.position = new Vector3(x,y,z);
			//tempObj.AddComponent<Type.GetType("Pulse")>("Pulse");
			//float r = 255;
			//float g = 153;
			//float b = 153;
			//tempObj.AddComponent<Renderer>().material.color = new Color(r,g,b);
		//}

		//if (ObjectType == 1) {

		//	GameObject tempObj = GameObject.CreatePrimitive(PrimitiveType.Cylinder) as GameObject;
		//	tempObj.transform.position = new Vector3(x,y,z);

			/*
			if (tempObj.activeSelf == false)
				tempObj.SetActive(true);
			Debug.Log ("Adding Object to scene");
			*/

			//tempObj.transform.lossyScale = new Vector3(5,5,5);
			//UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(tempObj, "Assets/Main.cs (40,4)", "Pulse.js");
			//tempObj.AddComponent<"TreblePulseType1.js">();

		//	float r = 153;
		//	float g = 204;
		//	float b = 255;
		//	tempObj.GetComponent<Renderer>().material.color = new Color(r,g,b);
	
		//}

		//objects.Add(tempObj);
		//edit location of main camera
		//mainCam.transform.position = new Vector3 (z, y, 0.5 * z);

	}

	// Use this for initialization
	void Start () {
		float beat1 = 0.6f;
		float beat2 = 4;
		createObject(0,0,3,beat1);
		createObject (1,0,2,beat2);
	}
	
	// Update is called once per frame
	void Update () {
		/*
		print (Input.GetKey ("up"));
		if (Input.GetKey ("up"))
			print ("up arrow key is held down");
		
		if (Input.GetKey ("down"))
			print ("down arrow key is held down");

		*/
	}

}
