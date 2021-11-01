using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PortionScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

private void Awake(){
        audioSource = GetComponent<AudioSource>();
    }

    void Playkey() {
        audioSource.PlayOneShot(audioClip);
    }
 void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Portion")){
            DoorScript.Doorscore += 1;
            Playkey();
            Destroy (col.gameObject);
         }
    }
}
