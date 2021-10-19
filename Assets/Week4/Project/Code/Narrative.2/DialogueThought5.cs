using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueThought5 : MonoBehaviour
{
    public static Text Thought5;
    // Start is called before the first frame update

    void Start(){
        Thought5 = GetComponent<Text>();
        Thought5.enabled = false;
    }
}
