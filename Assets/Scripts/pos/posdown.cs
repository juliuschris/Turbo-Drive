using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class posdown : MonoBehaviour
{
    public GameObject positionDisplay;
    public GameObject finishdis;



    void OnTriggerExit(Collider other){
    if(other.tag == "Carpos"){
        positionDisplay.GetComponent<Text>().text = "2nd";
        finishdis.GetComponent<Text>().text = "2nd Place";

        }
    }
}
