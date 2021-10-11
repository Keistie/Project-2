using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialoguePink : MonoBehaviour
{
    public static Text pinknpc;
    // Start is called before the first frame update

    void Start(){
        pinknpc = GetComponent<Text>();
        pinknpc.enabled = false;
    }
}
