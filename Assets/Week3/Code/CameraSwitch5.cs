using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch5 : MonoBehaviour
{
    public Camera Camera4;
    public Camera Camera5;
    
    public void Awake(){
        Camera Camera4 = GameObject.Find("Camera4").GetComponent<Camera>();
        Camera Camera5 = GameObject.Find("Camera5").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera4.enabled = false;
        Camera5.enabled = true;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
        }

    }
}
