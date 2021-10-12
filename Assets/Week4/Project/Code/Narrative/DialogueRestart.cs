using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueRestart : MonoBehaviour
{
    public static Text restart;
    // Start is called before the first frame update

    void Start(){
        restart = GetComponent<Text>();
        restart.enabled = false;
    }
}
