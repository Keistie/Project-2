using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch11 : MonoBehaviour
{
    public Camera Camera10;
    public Camera Camera11;
    public Color color11;
    
    
    public void Awake(){
        Camera Camera10 = GameObject.Find("Camera10").GetComponent<Camera>();
        Camera Camera11 = GameObject.Find("Camera11").GetComponent<Camera>();
        color11 = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

    }
    public void SwitchCamera(){
        Camera10.enabled = false;
        Camera11.enabled = true;
        Camera11.backgroundColor = color11;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
            col.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }

    }
}
