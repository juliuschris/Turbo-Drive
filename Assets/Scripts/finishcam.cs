using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishcam : MonoBehaviour {

	void Update () {
		transform.Rotate (0, 1, 0, Space.World);
	}
	IEnumerator End(){
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
		}
}


