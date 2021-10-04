using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch8 : MonoBehaviour
{
    // Start is called before the first frame update public Camera Camera6;
    public Camera Camera7;
    public Camera Camera8;
    
    
    public void Awake(){
        Camera Camera7 = GameObject.Find("Camera7").GetComponent<Camera>();
        Camera Camera8 = GameObject.Find("Camera8").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera7.enabled = false;
        Camera8.enabled = true;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
        }

    }
}
