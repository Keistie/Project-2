using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCamera : MonoBehaviour
{
    public Camera Camera0;
    public Camera Camera1;
    public Camera Camera2;
    public Camera Camera3;
    public Camera Camera4;
    public Camera Camera5;
    public Camera Camera6;
    public Camera Camera7;
    public Camera Camera8;
    public Camera Camera9;
    public Camera Camera10;
    public Camera Camera11;
    public Camera Camera12;

    public void Awake(){
        Camera Camera0 = GameObject.Find("Camera0").GetComponent<Camera>();
        Camera Camera1 = GameObject.Find("Camera1").GetComponent<Camera>();
        Camera Camera2 = GameObject.Find("Camera2").GetComponent<Camera>();
        Camera Camera3 = GameObject.Find("Camera3").GetComponent<Camera>();
        Camera Camera4 = GameObject.Find("Camera4").GetComponent<Camera>();
        Camera Camera5 = GameObject.Find("Camera5").GetComponent<Camera>();
        Camera Camera6 = GameObject.Find("Camera6").GetComponent<Camera>();
        Camera Camera7 = GameObject.Find("Camera7").GetComponent<Camera>();
        Camera Camera8 = GameObject.Find("Camera8").GetComponent<Camera>();
        Camera Camera9 = GameObject.Find("Camera9").GetComponent<Camera>();
        Camera Camera10 = GameObject.Find("Camera10").GetComponent<Camera>();
        Camera Camera11 = GameObject.Find("Camera11").GetComponent<Camera>();
        Camera Camera12 = GameObject.Find("Camera12").GetComponent<Camera>();
    }
    void Start()
    {
        Camera0.enabled = true;
        Camera1.enabled = false;
        Camera2.enabled = false;
        Camera3.enabled = false;
        Camera4.enabled = false;
        Camera5.enabled = false;
        Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = false;
        
    }
}

