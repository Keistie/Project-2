using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch7 : MonoBehaviour
{
    public Camera Camera6;
    public Camera Camera7;
    
    public void Awake(){
        Camera Camera6 = GameObject.Find("Camera6").GetComponent<Camera>();
        Camera Camera7 = GameObject.Find("Camera7").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera6.enabled = false;
        Camera7.enabled = true;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
        }

    }
}
