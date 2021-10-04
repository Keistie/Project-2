using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeself : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Block"){
            other.gameObject.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }
}
