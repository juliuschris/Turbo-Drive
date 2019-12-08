using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;

public class menu : MonoBehaviour {

	public void PlayGame () {
		SceneManager.LoadScene (2);
	}

	public void TrackSelect () {
		SceneManager.LoadScene (1);
	}

	public void MainMenu () {
        CarController.m_Topspeed = 100.0f;
		SceneManager.LoadScene (0);
	}

	public void doExitGame() {
     Application.Quit();
     }

	//Below here are track selection buttons

	public void Track01 () {
		SceneManager.LoadScene (2);
	}
	public void Track02 () {
		SceneManager.LoadScene (3);
	}
	public void Track03 () {
		SceneManager.LoadScene (4);
	}
	public void Track04 () {
		SceneManager.LoadScene (5);
	}

}
