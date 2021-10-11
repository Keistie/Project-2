using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueOrange : MonoBehaviour
{
    public static Text orangenpc;
    // Start is called before the first frame update

    void Start(){
        orangenpc = GetComponent<Text>();
        orangenpc.enabled = false;
    }
}
