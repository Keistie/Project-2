using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueThought1 : MonoBehaviour
{
    public static Text Thought1;
    // Start is called before the first frame update

    void Start(){
        Thought1 = GetComponent<Text>();
        Thought1.enabled = false;
    }
}
