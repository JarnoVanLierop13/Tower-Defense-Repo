using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    {
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

    public void EndGame()
    {
        Application.Quit();
    }

    public void ChangeScene(string scenename)
    {
        if (scenename == "Main")
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Single);

        }
        else if (scenename == "GameOver")
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        }

    }

}
