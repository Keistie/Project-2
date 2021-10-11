using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueBDes : MonoBehaviour
{
    public static Text BDes;
    // Start is called before the first frame update

    void Start(){
        BDes = GetComponent<Text>();
        BDes.enabled = false;
    }
}
