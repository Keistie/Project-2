using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch5 : MonoBehaviour
{
    public Camera Camera4;
    public Camera Camera5;
    public Color color5;
    
    public void Awake(){
        Camera Camera4 = GameObject.Find("Camera4").GetComponent<Camera>();
        Camera Camera5 = GameObject.Find("Camera5").GetComponent<Camera>();
        color5 = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

    }
    public void SwitchCamera(){
        Camera4.enabled = false;
        Camera5.enabled = true;
        Camera5.backgroundColor = color5;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
            col.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }

    }
}
