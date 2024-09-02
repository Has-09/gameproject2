using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject orr;
    private int speed = 40;
    void Update()
    {
        orr.transform.Rotate(new Vector3(0,1,0)*speed*Time.deltaTime); 
    }
}
