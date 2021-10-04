using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch2 : MonoBehaviour
{
    // Start is called before the first frame update    public Camera Camera0;
    public Camera Camera1;
    public Camera Camera2;
    
    public void Awake(){
        Camera Camera1 = GameObject.Find("Camera1").GetComponent<Camera>();
        Camera Camera2 = GameObject.Find("Camera2").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera1.enabled = false;
        Camera2.enabled = true;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
        }

    }
}
