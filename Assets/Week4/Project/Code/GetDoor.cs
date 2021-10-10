using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDoor : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("OldDoor")){
            if(GetKey.GetOldKey){
                DoorScript.Doorscore += 1;
                Destroy (col.gameObject);
            }
         }
        if(col.CompareTag("YellowDoor")){
            if(GetKey.GetYellowKey){
                DoorScript.Doorscore += 1;
                Destroy (col.gameObject);
            }
        }
        if(col.CompareTag("BlueDoor")){
            if(GetKey.GetBlueKey){
                DoorScript.Doorscore += 1;
                Destroy (col.gameObject);
            }
    }
    } 
}  
