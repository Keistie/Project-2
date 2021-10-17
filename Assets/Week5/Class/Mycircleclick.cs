using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mycircleclick : MonoBehaviour
{
   SpriteRenderer spriteRenderer;
   public Color colorone = Color.red;
   public Color colortwo = Color.green;
   private void awake(){
       spriteRenderer = GetComponent<SpriteRenderer>();
   }

   public void SelectButton(int n){

       if (n == 0)
       spriteRenderer.color = colorone;
       else if (n == 1) {
           spriteRenderer.color = colortwo;
    
       }

   }
}
