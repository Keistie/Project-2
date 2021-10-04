using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch2 : MonoBehaviour
{
    // Start is called before the first frame update    public Camera Camera0;
    public Camera Camera1;
    public Camera Camera2;
    public Color color2;
    
    public void Awake(){
        Camera Camera1 = GameObject.Find("Camera1").GetComponent<Camera>();
        Camera Camera2 = GameObject.Find("Camera2").GetComponent<Camera>();
        color2 = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

    }
    public void SwitchCamera(){
        Camera1.enabled = false;
        Camera2.enabled = true;
        Camera2.backgroundColor = color2;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
            col.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }

    }
}
