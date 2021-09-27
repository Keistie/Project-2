using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2.0f;

    public Rigidbody2D rb;

    public Animator animator;

    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*void MoveObject() {
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate((Vector2.left * Time.deltaTime) * speed);
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate((Vector2.right * Time.deltaTime) * speed);
        }
        if(Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate((Vector2.up * Time.deltaTime) * speed);
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate((Vector2.down * Time.deltaTime) * speed);
        }
    }
    */
    
    
    // Update is called once per frame
    void Update()
    {
        //MoveObject();

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal movement", movement.x);
        animator.SetFloat("Vertical movement", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

   void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

    }
}
