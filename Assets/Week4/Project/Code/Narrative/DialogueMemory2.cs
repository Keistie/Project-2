using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueMemory2 : MonoBehaviour
{
    public static Text Memory2;
    // Start is called before the first frame update

    void Start(){
        Memory2 = GetComponent<Text>();
        Memory2.enabled = false;
    }
}
