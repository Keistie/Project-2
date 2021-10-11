using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerDialogue1 : MonoBehaviour
{
    public static Text Dialogue;
    // Start is called before the first frame update

    void Start(){
        Dialogue = GetComponent<Text>();
        Dialogue.enabled = false;
    }
}
