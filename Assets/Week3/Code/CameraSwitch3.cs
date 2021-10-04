using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch3 : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera Camera2;
    public Camera Camera3;
    
    public void Awake(){
        Camera Camera2 = GameObject.Find("Camera2").GetComponent<Camera>();
        Camera Camera3 = GameObject.Find("Camera3").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera2.enabled = false;
        Camera3.enabled = true;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
        }

    }
}
