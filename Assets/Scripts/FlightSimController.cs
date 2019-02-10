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

	
	void Start() {
		client = new MongoClient(connectionString); 
        server = client.GetServer();
        database = server.GetDatabase("aerovizdb");

	}

	void Update() {
		//update collectionName here based on user input
	}

	public void Simulation() {
		//z = [1.8,3.2]
		//x = [-1.77, 1.3]

		collectionName = "flight1as";

		MongoCollection collection = database.GetCollection(collectionName);
		//the following doesn't work bc distinct returns a generic set for some reason
		//int[] sec = collection.Distinct<int>("Offset_sec");
		foreach (int i in collection.Distinct<int>("Offset_sec")) {
			Debug.Log(i);
		}
		////how to update weather sprite
		//weather.sprite = (Sprite)Resources.Load<Sprite>("weather/" + {nameOfpng.png}) as Sprite;

		//if there is an error, do this
		//alert.alpha = 1f;
		//warning.text = "error message or warning or smth here";
		// foreach (Renderer rend in plane.GetComponentsInChildren<Renderer>()) {
		// 	rend.materials = red; //else change to green
		// }

		//accessing plane's transform and updating it is like plane.transform and shit 
	}
}
