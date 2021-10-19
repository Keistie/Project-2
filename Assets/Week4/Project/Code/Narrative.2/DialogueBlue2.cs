using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueBlue2 : MonoBehaviour
{
     public static Text Blue2;
    // Start is called before the first frame update

    void Start(){
        Blue2 = GetComponent<Text>();
        Blue2.enabled = false;
    }
}
