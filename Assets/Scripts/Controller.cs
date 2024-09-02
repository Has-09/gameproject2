using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]private int speed = 4;

    private void Update() {

    if(Input.GetKey(KeyCode.W)){
       transform.Translate(new Vector3(0,0,1) * Time.deltaTime*speed);
    }
    if(Input.GetKey(KeyCode.S)){
        transform.Translate(new Vector3(0,0,-1)*Time.deltaTime*speed);
    }
    if(Input.GetKey(KeyCode.A)){
        transform.Translate(new Vector3(-1,0,0)*Time.deltaTime*speed);
    }
    if(Input.GetKey(KeyCode.D)){
        transform.Translate(new Vector3(1,0,0)*Time.deltaTime*speed);
    }
    }
}
