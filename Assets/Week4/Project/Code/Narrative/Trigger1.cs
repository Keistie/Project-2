using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            if(!GetKey.GetOldKey)
            Dialogue1.Dialogue.enabled = true;
            NBackground.Background.enabled = true;
        }
    }
 
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            Dialogue1.Dialogue.enabled = false;
            NBackground.Background.enabled = false;
        }
    }
}
