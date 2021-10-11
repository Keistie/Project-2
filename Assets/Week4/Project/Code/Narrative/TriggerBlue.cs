using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerBlue : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            DialogueBlue.bluenpc.enabled = true;
        }
    }
 
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            DialogueBlue.bluenpc.enabled = false;
        }
    }
}
