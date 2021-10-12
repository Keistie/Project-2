using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerBadend : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            if(DoorScript.Doorscore == 2){
                DialogueBadend.Badend.enabled = true;
            }
        }
        if (other.CompareTag("Player")){
            if(DoorScript.Doorscore == 1){
                DialogueBadend.Badend.enabled = true;
            }
        }
    }
}
