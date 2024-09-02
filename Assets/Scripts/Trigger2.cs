using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiger : MonoBehaviour
{
    public GameObject oopi;
   private void OnTriggerEnter(Collider other) {
    if(other.gameObject.name == "Kolli3"){
        oopi.SetActive(true);
    }
}
}
