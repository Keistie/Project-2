using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class GetKey : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;
public static bool GetYellowKey = false;
public static bool GetBlueKey = false;
public static bool GetOldKey = false;

private void Awake(){
        audioSource = GetComponent<AudioSource>();
    }

    void Playkey() {
        audioSource.PlayOneShot(audioClip);
    }
void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("YellowKey")){
            ScoreScript.Keyscore += 1;
            GetYellowKey = true;
            Playkey();
            Destroy (col.gameObject);
         }
        if(col.CompareTag("BlueKey")){
            ScoreScript.Keyscore += 1;
            GetBlueKey = true;
            Playkey();
            Destroy (col.gameObject);
        }
        if(col.CompareTag("OldKey")){
            ScoreScript.Keyscore += 1;
            GetOldKey = true;
            Playkey();
            Destroy (col.gameObject);
        }
    }
}
