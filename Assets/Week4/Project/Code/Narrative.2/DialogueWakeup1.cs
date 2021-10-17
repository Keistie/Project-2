using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueWakeup1 : MonoBehaviour
{
    public static Text Wakeup1;
    // Start is called before the first frame update

    void Start(){
        Wakeup1 = GetComponent<Text>();
        Wakeup1.enabled = false;
    }
}
