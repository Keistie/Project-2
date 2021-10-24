using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NBackground : MonoBehaviour
{
     public static Image Background;
    // Start is called before the first frame update

    void Start(){
        Background = GetComponent<Image>();
        Background.enabled = false;
    }
}
