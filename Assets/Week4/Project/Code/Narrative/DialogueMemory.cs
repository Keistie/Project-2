using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueMemory : MonoBehaviour
{
   public static Text Dialoguememory;
    // Start is called before the first frame update

    void Start(){
        Dialoguememory = GetComponent<Text>();
        Dialoguememory.enabled = false;
    }
}
