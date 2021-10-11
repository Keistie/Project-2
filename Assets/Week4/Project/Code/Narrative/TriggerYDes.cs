using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerYDes : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            DialogueYDes.YDes.enabled = true;
        }
    }
 
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            DialogueYDes.YDes.enabled = false;
        }
    }
}
