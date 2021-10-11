using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueMemory3 : MonoBehaviour
{
    public static Text Memory3;
    // Start is called before the first frame update

    void Start(){
        Memory3 = GetComponent<Text>();
        Memory3.enabled = false;
    }
}
