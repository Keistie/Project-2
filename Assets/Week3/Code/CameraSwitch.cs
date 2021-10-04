using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera Camera0;
    public Camera Camera1;
    public Rigidbody2D StartCirclerb;
    public Rigidbody2D StartCircle2rb;
    public Rigidbody2D SquareJointrb;
    public WheelJoint2D SquareJointWJ;
    public WheelJoint2D CircleJoint1;
    public float wmotorspeed = 1500f;
    public float cmotorspeed = 5000f;
    public Color color1 = Color.black;
    public void Awake(){
        Camera Camera0 = GameObject.Find("Camera0").GetComponent<Camera>();
        Camera Camera1 = GameObject.Find("Camera1").GetComponent<Camera>();
        StartCirclerb = GameObject.Find("StartCircle").GetComponent<Rigidbody2D>();
        StartCircle2rb = GameObject.Find("StartCircle2").GetComponent<Rigidbody2D>();
        SquareJointrb = GameObject.Find("SquareJoint1").GetComponent<Rigidbody2D>();
        SquareJointWJ = GameObject.Find("CircleJoint2").GetComponent<WheelJoint2D>();
        CircleJoint1 = GameObject.Find("CircleJoint1").GetComponent<WheelJoint2D>();

    }
    public void SwitchCamera(){
        Camera0.enabled = false;
        Camera1.enabled = true;
        Camera1.backgroundColor = color1; 
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag ("Player")){
            SwitchCamera();
            col.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            StartCirclerb.gravityScale = 3;
            StartCircle2rb.gravityScale = 3;
            SquareJointrb.gravityScale = 1;
            var motor = SquareJointWJ.motor;
            motor.motorSpeed = wmotorspeed;
            SquareJointWJ.motor = motor;
            var motor2 = CircleJoint1.motor;
            motor2.motorSpeed = cmotorspeed;
            CircleJoint1.motor = motor2;
        }

    }

 
}
