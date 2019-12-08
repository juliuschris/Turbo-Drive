using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lapcomplete : MonoBehaviour
{
    public GameObject lapcompletetrig;
    public GameObject halflaptrig;

    public GameObject menitdisplay;
    public GameObject detikdisplay;
    public GameObject milidisplay;

    public GameObject laptimebox;
    public GameObject lapcounter;
    public GameObject car;
    public int lapdone=0;
    public float RawTime;

    public GameObject RaceFinish;

    void Update(){
        if(lapdone == 2){
        RaceFinish.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other){

    if(other.tag=="Car"){
        lapdone +=1;
        RawTime  = PlayerPrefs.GetFloat("RawTime");
        if (laptime.RawTime <= RawTime){
        if(laptime.detik < 10){
            detikdisplay.GetComponent<Text>().text="0" + laptime.detik + ".";
        }

        else{
            detikdisplay.GetComponent<Text>().text="" + laptime.detik + ".";
        }

        if(laptime.menit < 10){
            menitdisplay.GetComponent<Text>().text="0" + laptime.menit + ":";
        }

        else{
            menitdisplay.GetComponent<Text>().text="" + laptime.menit + ":";
        }

        milidisplay.GetComponent<Text>().text= "" + laptime.mili.ToString("f0");
        }}

        PlayerPrefs.SetInt("MinSave", laptime.menit);
        PlayerPrefs.SetInt("SecSave", laptime.detik);
        PlayerPrefs.SetFloat("MiliSave", laptime.mili);
        PlayerPrefs.SetFloat("RawTime", laptime.RawTime);



    laptime.menit = 0;
    laptime.detik = 0;
    laptime.mili = 0;
    laptime.RawTime = 0;
    lapcounter.GetComponent<Text>().text= "" + lapdone;

    halflaptrig.SetActive(true);
    lapcompletetrig.SetActive(false);
    }

}
