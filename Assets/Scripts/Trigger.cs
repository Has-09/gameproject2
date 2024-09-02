using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggar : MonoBehaviour
{
    public GameObject oopi;
   private void OnTriggerEnter(Collider other) {
    if(other.gameObject.name == "Kolli"){
        oopi.SetActive(true);
    }
   }
}
