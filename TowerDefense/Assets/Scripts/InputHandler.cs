using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

    public static bool IsMouseDown() {

        if (Input.GetMouseButton(0) == true) { 
            return true;
        } else { return false; }
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
