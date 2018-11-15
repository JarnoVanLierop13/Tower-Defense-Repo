using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public void EndGame()
    {
        Application.Quit();
    }

    public void ChangeScene(string scenename)
    {
        if (scenename == "Main")
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Single);

        } else if(scenename == "GameOver")
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        }

    }
}
