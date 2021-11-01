using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class GetDoor2 : MonoBehaviour
{
    public string endScene1;
    public string endScene2;
    public string endScene3;

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
        if(col.CompareTag("OldDoor")){
                Playkey();
                SceneManager.LoadScene(endScene1);
                }

                /*if(DoorScript.Doorscore == 1){
                    DialogueBadend.Badend.enabled = true;
                    DialogueRestart.restart.enabled = true;
                    if(Input.GetKey(KeyCode.Space)){
                        SceneManager.LoadScene("Project 4");
                    }
                }
                if(DoorScript.Doorscore == 3){
                    DialogueGoodend.Goodend.enabled = true;
                    DialogueRestart.restart.enabled = true;
                    if(Input.GetKey(KeyCode.Space)){
                        SceneManager.LoadScene("Project 4");
                    }
                }*/
        if(col.CompareTag("YellowDoor")){
                Playkey();
                SceneManager.LoadScene(endScene2);
        }
        if(col.CompareTag("BlueDoor")){
                Playkey();
                SceneManager.LoadScene(endScene1);
        }
    } 
}
