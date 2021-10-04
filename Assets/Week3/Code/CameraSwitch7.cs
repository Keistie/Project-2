using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch7 : MonoBehaviour
{
    public Camera Camera6;
    public Camera Camera7;
    public Color color7 = Color.black;
    
    public void Awake(){
        Camera Camera6 = GameObject.Find("Camera6").GetComponent<Camera>();
        Camera Camera7 = GameObject.Find("Camera7").GetComponent<Camera>();

    }
    public void SwitchCamera(){
        Camera6.enabled = false;
        Camera7.enabled = true;
        Camera7.backgroundColor = color7;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
            col.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }

    }
}
