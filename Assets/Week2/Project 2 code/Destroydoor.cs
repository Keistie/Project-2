using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroydoor : MonoBehaviour
{
    public static int keyget = 0;
    void OnCollisionEnter2D (Collision2D other)
    {
    if (keyget == 1){
    Destroy (gameObject);

        }
    }
}
