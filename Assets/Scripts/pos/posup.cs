using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class posup : MonoBehaviour
{
    public GameObject positionDisplay;
    public GameObject finishdis;
    public static int win=0;

    void OnTriggerExit(Collider other){
    if(other.tag == "Carpos"){
        win=1;
        positionDisplay.GetComponent<Text>().text = "1st";
        finishdis.GetComponent<Text>().text = "1st Place";
        }
    }
}
