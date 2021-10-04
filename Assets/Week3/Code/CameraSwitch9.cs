using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch9 : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera Camera8;
    public Camera Camera9;
    public Color color9;
    
    
    public void Awake(){
        Camera Camera8 = GameObject.Find("Camera8").GetComponent<Camera>();
        Camera Camera9 = GameObject.Find("Camera9").GetComponent<Camera>();
        color9 = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

    }
    public void SwitchCamera(){
        Camera8.enabled = false;
        Camera9.enabled = true;
        Camera9.backgroundColor = color9;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
            col.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }

    }
}
