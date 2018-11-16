using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler {

    /* 
     
         
         Uit dit script wordt tot nu toe alleen nog de escape key down gebruikt (ja op dit moment is dit script overbodig),
         maar we wilden meer functionaliteiten toevoegen die userinput nodig hebben om te functioneren.
         
         
         
         
         */

    public static bool IsLeftMouseDown() {

        if (Input.GetMouseButton(0) == true) { 
            return true;
        } else { return false; }
    }

    public static bool IsRightMouseDown()
    {

        if (Input.GetMouseButton(1) == true)
        {
            return true;
        }
        else { return false; }
    }

    public static bool IsAnyKeyDown()
    {
        if (Input.anyKeyDown == true)
        {
            return true;
        } else { return false; }
    }

    public static bool IsEscapePressed()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            return true;
        }
        else { return false; }
    }

}
