using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch6 : MonoBehaviour
{
    public Camera Camera5;
    public Camera Camera6;
    
    public void Awake(){
        Camera Camera5 = GameObject.Find("Camera5").GetComponent<Camera>();
        Camera Camera6 = GameObject.Find("Camera6").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera5.enabled = false;
        Camera6.enabled = true;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
        }

    }
}
