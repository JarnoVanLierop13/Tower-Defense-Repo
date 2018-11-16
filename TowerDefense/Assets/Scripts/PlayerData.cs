using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerData {

    public int playerPoints;
    private int playerHealth;

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
