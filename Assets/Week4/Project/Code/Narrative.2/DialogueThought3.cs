using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueThought3 : MonoBehaviour
{
    public static Text Thought3;
    // Start is called before the first frame update

    void Start(){
        Thought3 = GetComponent<Text>();
        Thought3.enabled = false;
    }
}
