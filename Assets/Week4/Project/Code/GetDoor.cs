using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GetDoor : MonoBehaviour
{
    public GameObject Blackcanva;

    public string nextScene;
void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("OldDoor")){
            if(GetKey.GetOldKey){
                DoorScript.Doorscore += 1;
                Destroy (col.gameObject);
                SceneManager.LoadScene(nextScene);
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
