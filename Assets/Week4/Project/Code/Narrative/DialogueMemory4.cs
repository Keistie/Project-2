using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueMemory4 : MonoBehaviour
{
   public static Text Memory4;
    // Start is called before the first frame update

    void Start(){
        Memory4 = GetComponent<Text>();
        Memory4.enabled = false;
    }
}
