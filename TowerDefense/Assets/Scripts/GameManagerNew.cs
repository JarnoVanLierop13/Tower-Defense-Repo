using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerNew : MonoBehaviour {

    public PlayerData playerData = new PlayerData();
    public Text displayedScore;
    public Text displayedHP;

    private void Awake()
    {
        playerData.SetStartData(550, 3);
    }

    private void Update () {
        SetScore();
        playerData.IsDead();
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
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }

    }

    private void SetScore()
    {
        displayedScore.text = "Score: " + playerData.playerPoints;
        displayedHP.text = "Lives: " + playerData.playerHealth;
    }

    
}
