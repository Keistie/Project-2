using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startforce : MonoBehaviour
{
    Rigidbody2D rb;
    bool right;
    public float power = 1.0f;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void CheckInput(){
        if(Input.GetKey(KeyCode.Space)) {
            right = true;
        }
    }

    private void Update(){
        CheckInput();
    }

    private void FixedUpdate(){
        if(right){
            rb.AddForce(Vector2.right * power);
        }
    }
}
