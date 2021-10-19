using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortionScript : MonoBehaviour
{
 void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Portion")){
            DoorScript.Doorscore += 1;
            Destroy (col.gameObject);
         }
    }
}
