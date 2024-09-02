using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotation : MonoBehaviour
{
    public Transform[] transforms = new Transform[5];

    public float speed = 70f;
    private void Update() {
        for(int i = 0; i<transforms.Length;i++){
            transforms[i].Rotate(new Vector3(0,5,0)*speed*Time.deltaTime);
        }
    }
}
