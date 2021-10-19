using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueOrange2 : MonoBehaviour
{
   public static Text Orange2;
    // Start is called before the first frame update

    void Start(){
        Orange2 = GetComponent<Text>();
        Orange2.enabled = false;
    }
}
