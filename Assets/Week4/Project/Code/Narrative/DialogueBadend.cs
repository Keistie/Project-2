using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueBadend : MonoBehaviour
{
    public static Text Badend;
    // Start is called before the first frame update

    void Start(){
        Badend = GetComponent<Text>();
        Badend.enabled = false;
    }
}
