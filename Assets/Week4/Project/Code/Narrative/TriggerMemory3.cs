using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerMemory3 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            DialogueMemory3.Memory3.enabled = true;
        }
    }
 
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            DialogueMemory3.Memory3.enabled  = false;
        }
    }
}
