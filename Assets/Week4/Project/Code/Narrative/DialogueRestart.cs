using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DialogueRestart : MonoBehaviour
{
    public string level2;
   public void restartlevel(){
        if(Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(level2);
        }
    }

    public void Update(){
        restartlevel();
    }
}
