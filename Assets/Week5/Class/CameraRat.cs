using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraRat : MonoBehaviour
{
    Camera mainCamera;
   public TMP_Text myText;
   int points = 0;
    private void awake() {
        mainCamera = Camera.main;
    }

    void ClickCheck (){
        if(Input.GetMouseButtonDown(0)) {
            RaycastHit2D ray = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Input.mousePosition));

            if(ray.collider != null && ray.collider.CompareTag("ClickButton")) {
            ray.collider.GetComponent<Mycircleclick>().SelectButton(0);

        }
        points += 1;
        myText.text = "Points: " + points;
        }
        else if(Input.GetMouseButtonDown(1)) {

            RaycastHit2D ray = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Input.mousePosition));
            if(ray.collider != null && ray.collider.CompareTag("ClickButton")) {
                ray.collider.GetComponent<Mycircleclick>().SelectButton(1);
        }
        points -= 1;
        myText.text = "Points: " + points;
    }
    }

     private void Update() {
        ClickCheck();
    }
}
