using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueOldDes : MonoBehaviour
{
    public static Text ODes;
    // Start is called before the first frame update

    void Start(){
        ODes = GetComponent<Text>();
        ODes.enabled = false;
    }
}
