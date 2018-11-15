using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData {

    private int playerPoints;
    [SerializeField]
    private int playerHealth;

    public GameManagerNew menuCode = new GameManagerNew();

    public void SetData()
    {
        playerPoints = 550;
        playerHealth = 3;
    }

    public void EnemyReachedEnd()
    {
        playerHealth -= 1;
    }

    public void IsDead()
    {
        if (playerHealth <= 0)
        {
            menuCode.ChangeScene("GameOver");
        }
    }
}
