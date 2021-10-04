using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch4 : MonoBehaviour
{
 
    public Camera Camera3;
    public Camera Camera4;
    public Color color4 = Color.black;
    
    public void Awake(){
        Camera Camera3 = GameObject.Find("Camera3").GetComponent<Camera>();
        Camera Camera4 = GameObject.Find("Camera4").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera3.enabled = false;
        Camera4.enabled = true;
        Camera4.backgroundColor = color4;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
            col.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }

    }
}
