using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDoor : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("OldDoor")){
            if(GetKey.GetOldKey){
                Destroy (col.gameObject);
            }
         }
        if(col.CompareTag("YellowDoor")){
            if(GetKey.GetYellowKey){
                Destroy (col.gameObject);
            }
        }
        if(col.CompareTag("BlueKey")){
            if(GetKey.GetBlueKey){
                Destroy (col.gameObject);
            }
    }
    } 
}  
