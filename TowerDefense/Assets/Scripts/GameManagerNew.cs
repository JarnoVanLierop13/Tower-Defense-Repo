using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerNew : MonoBehaviour {

    public PlayerData playerData = new PlayerData();

    private void Awake()
    {
        playerData.SetData();
    }

    void Update () {
        playerData.IsDead();
	}
}
