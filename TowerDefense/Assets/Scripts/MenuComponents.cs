using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuComponents : MonoBehaviour {

    private bool IsPaused = false;

    private void Update()
    {
        CheckPauseState();
    }

    private void PauseGame()
    {
        if (IsPaused == true)
        {
            Time.timeScale = 1;
        } else
        {
            Time.timeScale = 0;
        }
    }

    private void CheckPauseState()
    { // checkt of de game gepauzeerd is en voert de nodige functie uit, zodat we niet 2 verschillende knoppen nodig hebben voor alleen pauze
        if (InputHandler.IsEscapePressed() == true && IsPaused == false)
        {
            PauseGame();
            IsPaused = true;
        }
        else if (InputHandler.IsEscapePressed() == true && IsPaused == true)
        {
            PauseGame();
            IsPaused = false;
        }
    }

    

}
