using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch10 : MonoBehaviour
{
    public Camera Camera9;
    public Camera Camera10;
    
    
    public void Awake(){
        Camera Camera9 = GameObject.Find("Camera9").GetComponent<Camera>();
        Camera Camera10 = GameObject.Find("Camera10").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera9.enabled = false;
        Camera10.enabled = true;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
        }

    }
}
