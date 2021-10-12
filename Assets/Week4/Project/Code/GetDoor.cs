using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GetDoor : MonoBehaviour
{
    public GameObject Blackcanva;
void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("OldDoor")){
            if(GetKey.GetOldKey){
                DoorScript.Doorscore += 1;
                Destroy (col.gameObject);
                Blackcanva.SetActive (true);
                if(DoorScript.Doorscore == 2){
                    DialogueBadend.Badend.enabled = true;
                    DialogueRestart.restart.enabled = true;
                    if(Input.GetKey(KeyCode.Space)){
                        SceneManager.LoadScene("Project 4");
                    }
                }
                if(DoorScript.Doorscore == 1){
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
                }
            }
         }
        if(col.CompareTag("YellowDoor")){
            if(GetKey.GetYellowKey){
                DoorScript.Doorscore += 1;
                Destroy (col.gameObject);
            }
        }
        if(col.CompareTag("BlueDoor")){
            if(GetKey.GetBlueKey){
                DoorScript.Doorscore += 1;
                Destroy (col.gameObject);
            }
    }
    } 
}  
