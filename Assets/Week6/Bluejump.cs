using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bluejump : MonoBehaviour
{
    public Animator animator;

    void CharacterInput(){
        if(Input.GetKeyDown(KeyCode.Space)){
            animator.SetTrigger("jump");
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