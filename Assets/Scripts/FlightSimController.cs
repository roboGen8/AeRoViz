using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading;
using System.IO;

public class FlightSimController : MonoBehaviour
{
	//for flight controller
	public Text coords, flightnum, location, planedata, time, airbus, warning;
	public CanvasGroup alert;
	public Image weather;
	public GameObject holo, planebody, plane, altitude, airspeed;
	public Material green;
	public Material red;
	public TextAsset data;

	//for main menu

	public const string connectionString = "mongodb://admin:Dasani112@ds145704.mlab.com:45704/aerovizdb";
    public const int Max = 100;
	public const int WaitTime = 3;

	private MongoClient client;
	private MongoServer server;
	private MongoDatabase database;
	private string collectionName;
	float deltatime;
	float oldtime;
	float starttime;
	void Start() {
		// client = new MongoClient(connectionString);
  //       server = client.GetServer();
  //       database = server.GetDatabase("aerovizdb");
  		deltatime = Time.time;
		oldtime = 0;
		starttime = 0;
	}

	void Update() {
		//update collectionName here based on user input
		location.text = "ATL - CAI";
		coords.text = plane.transform.position.x + " \n" + plane.transform.position.y + " \n" + plane.transform.position.z;
		if (Time.time - oldtime >= 1) {
			if (starttime < 10) {
				time.text = "13:0" + starttime++;
			} else {
				time.text = "13:" + starttime++;
			}

			oldtime = Time.time;
		}
		if (Time.time - deltatime > 16) {
			alert.alpha = 1f;
			warning.text = "2 hours in cruise at 34;000 ft we experienced a L1 (Captain's front windshield) outer pane failure. The L FWD Window EICAS message illuminated. There was brief arcing of the window heat probe. We also had a loud cracking sound.We ran the L FWD WINDOW QRH checklist. We turned off the L FWD Window Heat; then ran the Window Damage checklist. Once we determined that the outer pane failed but the inner pane was intact; we elected to continue to [destination] per the checklist.We decided to [advise ATC] for landing as I could not see well enough out the window to taxi off the runway and to the gate.The First Officer made the landing and after ARFF checked us for any other damage; we shut down the engines and awaited towing.We gave Ops and Dispatch plenty of notice that we would need to be towed off the runway; however when we landed there was no tug. We called Ops continuously asking for a tug and it took 30 minutes for them to finally show up. This caused [a] runway to be needlessly shut down. Once the tug finally showed up we were towed to the gate.The outer pane of the L1 window failed due to a short in the window heat system.";
			////how to update weather sprite
			//weather.sprite = (Sprite)Resources.Load<Sprite>("weather/" + {nameOfpng.png}) as Sprite;

			//if there is an error, do this
			//alert.alpha = 1f;
			//warning.text = "error message or warning or smth here";
			foreach (Renderer rend in planebody.GetComponentsInChildren<Renderer>()) {
				rend.material = red; //else change to green
			}
			deltatime = -500;
		}

	}

	void Simulation() {
		//z = [1.8,3.2]
		//x = [-1.77, 1.3]
		Debug.Log("hello");
		// collectionName = "flight1as";

		// MongoCollection collection = database.GetCollection(collectionName);
		//the following doesn't work bc distinct returns a generic set for some reason
		//int[] sec = collection.Distinct<int>("Offset_sec");
		// foreach (int i in collection.Distinct<int>("Offset_sec")) {
		// 	Debug.Log(i);
		// }
		location.text = "ATL - CAI";

		for (int i = 0; i < 10000; i++) {
			int count = 0;
			while(count < 50000000) {
				coords.text = plane.transform.position.x + "\n" + plane.transform.position.y + "\n" + plane.transform.position.z;
				count++;
			}

		}
		alert.alpha = 1f;
		warning.text = "2 hours in cruise at 34;000 ft we experienced a L1 (Captain's front windshield) outer pane failure. The L FWD Window EICAS message illuminated. There was brief arcing of the window heat probe. We also had a loud cracking sound.We ran the L FWD WINDOW QRH checklist. We turned off the L FWD Window Heat; then ran the Window Damage checklist. Once we determined that the outer pane failed but the inner pane was intact; we elected to continue to [destination] per the checklist.We decided to [advise ATC] for landing as I could not see well enough out the window to taxi off the runway and to the gate.The First Officer made the landing and after ARFF checked us for any other damage; we shut down the engines and awaited towing.We gave Ops and Dispatch plenty of notice that we would need to be towed off the runway; however when we landed there was no tug. We called Ops continuously asking for a tug and it took 30 minutes for them to finally show up. This caused [a] runway to be needlessly shut down. Once the tug finally showed up we were towed to the gate.The outer pane of the L1 window failed due to a short in the window heat system.";
		////how to update weather sprite
		//weather.sprite = (Sprite)Resources.Load<Sprite>("weather/" + {nameOfpng.png}) as Sprite;

		//if there is an error, do this
		//alert.alpha = 1f;
		//warning.text = "error message or warning or smth here";
		foreach (Renderer rend in planebody.GetComponentsInChildren<Renderer>()) {
			rend.material = red; //else change to green
		}
		for (int i = 0; i < 10000; i++) {
			int count = 0;
			while (count < 5000000) {
				coords.text = plane.transform.position.x + "\n" + plane.transform.position.y + "\n" + plane.transform.position.z;

				count++;
			}
		}
		//accessing plane's transform and updating it is like plane.transform and shit
	}
}
