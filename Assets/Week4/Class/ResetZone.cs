using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetZone : MonoBehaviour
{
    public PeggleBall mpb;
    public Shooter mps;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject == mpb.gameObject){
            mps.ResetBall();
            
        }

    }
}
