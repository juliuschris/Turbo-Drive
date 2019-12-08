using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laptime : MonoBehaviour
{
    public static int menit;
    public static int detik;
    public static float mili;
    public static string milidisplay;

    public GameObject menitbox;
    public GameObject detikbox;
    public GameObject milibox;

    public static float RawTime;

    void Update()
    {

        mili += Time.deltaTime * 10;
        RawTime +=Time.deltaTime;
        milidisplay = mili.ToString("f0");
        milibox.GetComponent<Text>().text = "" + milidisplay;

        if(mili > 9){
            mili=0;
            detik+=1;
        }

        if(detik < 10){
            detikbox.GetComponent<Text>().text = "0" + detik + '.';
        }
        else{
            detikbox.GetComponent<Text>().text = "" + detik + '.';
        }

        if(detik >=60){
            detik=0;
            menit+=1;
        }

        if(menit <=9){
            menitbox.GetComponent<Text>().text = "0" + menit + ':';
        }
        else{
            menitbox.GetComponent<Text>().text = "" + menit + ':';
        }
    }



}
