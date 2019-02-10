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
	public Text coords, flightnum, location, planedata, time, airbus, warning;
	public CanvasGroup alert;
	public Image weather;
	public GameObject plane, altitude, airspeed;
	public Material green;
	public Material red;
	public TextAsset data;

	public const string connectionString = "mongodb://admin:Dasani112@ds145704.mlab.com:45704/aerovizdb";
    public const int Max = 100;
	public const int WaitTime = 3;

	void Start() {
		MongoClient client = new MongoClient(connectionString); 
        MongoServer server = client.GetServer();
        MongoDatabase database = server.GetDatabase("aerovizdb");
        string collectionName = "flight1as";

		MongoCollection collection = database.GetCollection(collectionName);
		//Debug.Log("THis is collection: " + collection.find("5c5f62c4864b4a20847a1dd5"));
	}

	public void Simulation() {
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
