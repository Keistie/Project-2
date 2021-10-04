using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch12 : MonoBehaviour
{
    public Camera Camera11;
    public Camera Camera12;
    
    
    public void Awake(){
        Camera Camera11 = GameObject.Find("Camera11").GetComponent<Camera>();
        Camera Camera12 = GameObject.Find("Camera12").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera11.enabled = false;
        Camera12.enabled = true;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
        }

    }
}
