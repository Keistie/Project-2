using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
public static bool GetYellowKey = false;
public static bool GetBlueKey = false;
public static bool GetOldKey = false;
void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("YellowKey")){
            ScoreScript.Keyscore += 1;
            GetYellowKey = true;
            Destroy (col.gameObject);
         }
        if(col.CompareTag("BlueKey")){
            ScoreScript.Keyscore += 1;
            GetBlueKey = true;
            Destroy (col.gameObject);
        }
        if(col.CompareTag("OldKey")){
            ScoreScript.Keyscore += 1;
            GetOldKey = true;
            Destroy (col.gameObject);
        }
    }
}
