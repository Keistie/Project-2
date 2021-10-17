using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueThought2 : MonoBehaviour
{
    public static Text Thought2;
    // Start is called before the first frame update

    void Start(){
        Thought2 = GetComponent<Text>();
        Thought2.enabled = false;
    }
}
