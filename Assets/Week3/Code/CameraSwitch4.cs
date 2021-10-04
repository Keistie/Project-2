using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch4 : MonoBehaviour
{
 
    public Camera Camera3;
    public Camera Camera4;
    
    public void Awake(){
        Camera Camera3 = GameObject.Find("Camera3").GetComponent<Camera>();
        Camera Camera4 = GameObject.Find("Camera4").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera3.enabled = false;
        Camera4.enabled = true;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
        }

    }
}
