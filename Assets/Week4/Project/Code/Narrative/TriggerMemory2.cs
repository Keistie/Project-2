using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerMemory2 : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            DialogueMemory2.Memory2.enabled = true;
            NBackground.Background.enabled = true;
        }
    }
 
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            DialogueMemory2.Memory2.enabled = false;
            NBackground.Background.enabled = false;
        }
    }
}
