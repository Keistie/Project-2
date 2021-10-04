using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch10 : MonoBehaviour
{
    public Camera Camera9;
    public Camera Camera10;
    public Color color10 = Color.black;
    
    
    public void Awake(){
        Camera Camera9 = GameObject.Find("Camera9").GetComponent<Camera>();
        Camera Camera10 = GameObject.Find("Camera10").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera9.enabled = false;
        Camera10.enabled = true;
        Camera10.backgroundColor = color10;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
            col.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }

    }
}
