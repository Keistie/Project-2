using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int Keyscore = 0;
    public Text sc;
    //public int sc = Keyscore;
    // Update is called once per frame
    void Start(){
    }
    
    void Update()
    {
        //sc = Keyscore;
        sc.text = "Key: " + Keyscore;
    }
}
