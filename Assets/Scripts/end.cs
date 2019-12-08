using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour {

    public GameObject largeButton;
    public GameObject textClick;
    public GameObject menuButtons;

    public void StartMenu()
    {
        textClick.SetActive(false);
        SceneManager.LoadScene("mainmenu");
    }

}
