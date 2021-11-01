using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
   public string level1;
   public void startlevel(){
        if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(level1);
        }
    }

    public void Update(){
        startlevel();
    }
}
