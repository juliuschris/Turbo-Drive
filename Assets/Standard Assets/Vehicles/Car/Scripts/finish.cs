using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class finish : MonoBehaviour {

	public GameObject MyCar;
	public GameObject FinishCam;
	public GameObject ViewModes;
	public GameObject LevelMusic;
	public GameObject CompleteTrig;
	public GameObject LapTimer;
	public AudioSource FinishMusic;
	public GameObject positionDisplay;
	public GameObject finishdis;
	public GameObject posup;
	public GameObject posdown;
	public GameObject but;
	public GameObject butdis;


	void OnTriggerEnter () {
		this.GetComponent<BoxCollider> ().enabled = false;
		LapTimer.SetActive (false);
		posup.SetActive(false);
		posdown.SetActive(false);
		CompleteTrig.SetActive (false);
		CarController.m_Topspeed = 10.0f;
		finishdis.SetActive(true);
		FinishCam.SetActive (true);
		LevelMusic.SetActive (false);
		ViewModes.SetActive (false);
		posup.SetActive(false);
		posdown.SetActive(false);
		but.SetActive(true);
		butdis.SetActive(true);

	}


}
