using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData {

    public int playerPoints;
    public int playerHealth;

    public void SetStartData(int points, int health)
    {
        playerPoints = points;
        playerHealth = health;
    }

    public void GivePoints(int amount)
    {
        playerPoints += amount;
    }

    public void EnemyReachedEnd()
    {
        playerHealth -= 1;
    }

    public void IsDead()
    {
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        }
    }
}
