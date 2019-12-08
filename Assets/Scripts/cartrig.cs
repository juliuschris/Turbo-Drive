using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class cartrig : MonoBehaviour {

	public GameObject MyCar;

	void OnTriggerEnter () {

		MyCar.SetActive (true);

	}

}
