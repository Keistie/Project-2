using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch8 : MonoBehaviour
{
    // Start is called before the first frame update public Camera Camera6;
    public Camera Camera7;
    public Camera Camera8;
    public Color color8;
    
    
    public void Awake(){
        Camera Camera7 = GameObject.Find("Camera7").GetComponent<Camera>();
        Camera Camera8 = GameObject.Find("Camera8").GetComponent<Camera>();
        color8 = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

    }
    public void SwitchCamera(){
        Camera7.enabled = false;
        Camera8.enabled = true;
        Camera8.backgroundColor = color8;
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
            col.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }

    }
}
