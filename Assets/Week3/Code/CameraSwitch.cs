using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera Camera0;
    public Camera Camera1;
    
    public void Awake(){
        Camera Camera0 = GameObject.Find("Camera0").GetComponent<Camera>();
        Camera Camera1 = GameObject.Find("Camera1").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera0.enabled = false;
        Camera1.enabled = true;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
        }

    }

 
}