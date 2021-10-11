using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueHint : MonoBehaviour
{
    public static Text hint;
    // Start is called before the first frame update

    void Start(){
        hint = GetComponent<Text>();
        hint.enabled = false;
    }
}
