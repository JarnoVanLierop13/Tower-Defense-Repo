using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerNew : MonoBehaviour {

    public PlayerData playerData = new PlayerData();
    public Text displayedScore;

    private void Awake()
    {
        playerData.SetStartData(550, 3);
    }

    private void Update () {
        playerData.IsDead();
        SetScore();
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

    private void SetScore()
    {
        displayedScore.text = "Score: " + playerData.playerPoints;
    }

    
}
