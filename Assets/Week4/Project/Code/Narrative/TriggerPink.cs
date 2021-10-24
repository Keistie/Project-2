using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerPink : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
                DialoguePink.pinknpc.enabled = true;
                NBackground.Background.enabled = true;
        }
    }
 
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            DialoguePink.pinknpc.enabled = false;
            NBackground.Background.enabled = false;
        }
    }
}
