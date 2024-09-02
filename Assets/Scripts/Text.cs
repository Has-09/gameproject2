using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Text : MonoBehaviour
{
    private int _coints;
    public TextMeshProUGUI scoreText;
    
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Coints"){
            _coints++;

            Destroy(other.gameObject);
            scoreText.text = "Coints: "+ _coints;
        }
    }
}
