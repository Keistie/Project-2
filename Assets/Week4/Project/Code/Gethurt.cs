using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gethurt : MonoBehaviour
{
    public string deathScene;
    public GameObject Blackcanva;
    public void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Interact")){
            DoorScript.Doorscore -= 1;
        }
    }
    public void checkhealth(){
        if(DoorScript.Doorscore == 0){
            SceneManager.LoadScene(deathScene);
        }
    }

    void update(){
        checkhealth();
    }

}
