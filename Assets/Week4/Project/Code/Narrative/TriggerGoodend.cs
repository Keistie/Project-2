using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerGoodend : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            if(DoorScript.Doorscore == 3){
                DialogueGoodend.Goodend.enabled = true;
            }
        }
    }
}
