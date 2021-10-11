using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueYDes : MonoBehaviour
{
    public static Text YDes;
    // Start is called before the first frame update

    void Start(){
        YDes = GetComponent<Text>();
        YDes.enabled = false;
    }
}
