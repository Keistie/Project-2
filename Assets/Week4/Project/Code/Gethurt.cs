using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class Gethurt : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;
    public string deathScene;
    public GameObject Blackcanva;

    private void Awake(){
        audioSource = GetComponent<AudioSource>();
    }

    void Playkey() {
        audioSource.PlayOneShot(audioClip);
    }
    public void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Interact")){
            DoorScript.Doorscore -= 1;
            Playkey();
        }
    }
    public void checkhealth(){
        if(DoorScript.Doorscore == 0){
            SceneManager.LoadScene(deathScene);
        }
    }

    public void Update(){
        checkhealth();
    }

}
