using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
     public Animator animator;

    void CharacterInput(){
        if(!Input.anyKey){
            animator.SetTrigger("IDLE");
        }
        else if(Input.GetKey(KeyCode.A)){
            animator.SetTrigger("LEFT");
        }
        else if(Input.GetKey(KeyCode.D)){
            animator.SetTrigger("RIGHT");
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        CharacterInput();
    }
}
