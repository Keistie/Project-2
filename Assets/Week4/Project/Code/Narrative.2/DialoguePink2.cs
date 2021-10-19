using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialoguePink2 : MonoBehaviour
{
    public static Text Pink2;
    // Start is called before the first frame update

    void Start(){
        Pink2 = GetComponent<Text>();
        Pink2.enabled = false;
    }
}
