using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueThought4 : MonoBehaviour
{
     public static Text Thought4;
    // Start is called before the first frame update

    void Start(){
        Thought4 = GetComponent<Text>();
        Thought4.enabled = false;
    }
}
