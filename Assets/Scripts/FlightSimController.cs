using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlightSimController : MonoBehaviour
{
	public Text coords, flightnum, location, planedata, time, airbus, warning;
	public CanvasGroup alert;
	public Image weather;
	public GameObject plane, altitude, airspeed;
	public Material green;
	public Material red;
	public TextAsset data;

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
