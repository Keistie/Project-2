using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleRandom : MonoBehaviour
{
    public GameObject blockPrefab;
    public int Seed = 0;

    public void Start() {
        Random.InitState(Seed);
    }

    void SpawnBlockObject (){
        float x = Random.Range(-8.0f, 8.0f);
        float y = Random.Range(-5.0f, 5.0f);
        GameObject b = Instantiate(blockPrefab, new Vector3 (x, y), Quaternion.identity);

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            SpawnBlockObject();

        }
        if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}
