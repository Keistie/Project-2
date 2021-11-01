using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IntExtension
{
    public static bool isBetween(this int x, int lower, int upper){
        bool n = false;

        if (x >= lower && x <= upper)
            n = true;
        



        return n; 
    }
}
