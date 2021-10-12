using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueGoodend : MonoBehaviour
{
    public static Text Goodend;
    // Start is called before the first frame update

    void Start(){
        Goodend = GetComponent<Text>();
        Goodend.enabled = false;
    }
}
