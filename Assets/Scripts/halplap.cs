using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halplap : MonoBehaviour{

   public GameObject halflap;
   public GameObject lapcomplete;

   void OnTriggerEnter(Collider other){
   if(other.tag=="Car"){
        lapcomplete.SetActive(true);
        halflap.SetActive(false);
   }}
}
