using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
     public Animator animator;

    void CharacterInput(){
        if(Input.GetKey(KeyCode.A)){
            animator.SetTrigger("LEFT");
        }
        if(Input.GetKey(KeyCode.D)){
            animator.SetTrigger("RIGHT");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterInput();
    }
}
