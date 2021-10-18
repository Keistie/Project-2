using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript2 : MonoBehaviour
{
   public static int live = 1;
    public Text LV;
    //public int sc = Keyscore;
    // Update is called once per frame
    void Start(){
    }
    
    void Update() 
    {
        //sc = Keyscore;
        LV.text = "Life: " + live;
    }
}
