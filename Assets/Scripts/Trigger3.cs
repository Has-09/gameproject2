using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troggar : MonoBehaviour
{
    public GameObject oops;
    public GameObject resk;

    public GameObject tere;
   private void OnTriggerEnter(Collider other) {
    if(other.gameObject.name == "Kolli2"){
        oops.SetActive(false);
    }
    if(other.gameObject.name=="Kolli4"){
        resk.SetActive(false);
    }
    if(other.gameObject.name=="Kolli5"){
        tere.SetActive(true);

    }
   }
}
