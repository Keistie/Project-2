using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed, jumpPower = 5.0f;
    public bool onGround;
    bool canJump = true;
    float moveX = 1.0f;
    // Start is called before the first frame update
    private void Awake(){
        rb = GetComponent<Rigidbody2D>(); 
    }

    void PlayerControls(){
        if(Input.GetKeyDown(KeyCode.Space)){
            canJump = true;
        }

        moveX = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftShift)){
            moveSpeed = 10.0f;
        }
        else {
            moveSpeed = 5.0f;
        }
        if (Input.GetKey(KeyCode.F)){
            jumpPower = 10.0f;
        }
        else{
            jumpPower = 5.0f;
        }

    }

    void Jump(){
        if(!onGround)
            return;
        
        rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        onGround = false;

    }

    private void OnCollisionEnter2D(Collision2D collision){
        onGround = true;
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
        if(canJump){
            canJump = false;
            Jump();
        }

    }
    // Update is called once per frame
    void Update()
    {
        PlayerControls();
    }
}
