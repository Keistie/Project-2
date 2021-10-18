using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gethurt : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("OldDoor")){
            ScoreScript2.live -= 1;
        }
    }

}
