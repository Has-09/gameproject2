using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed;


    private void Update() {
       var direction = (player.position-transform.position).normalized;
       transform.Translate(direction*speed*Time.deltaTime);
    } 
        

}

