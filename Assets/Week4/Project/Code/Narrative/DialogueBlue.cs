using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueBlue : MonoBehaviour
{
     public static Text bluenpc;
    // Start is called before the first frame update

    void Start(){
        bluenpc = GetComponent<Text>();
        bluenpc.enabled = false;
    }
}
