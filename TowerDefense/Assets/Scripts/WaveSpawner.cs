using System.Collections;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

    public Transform enemyPrefab;//reference

    public Transform spawnPoint;//reference

    private float countdown = 1f;//time before 1st wave

    public float TimebetweenWaves = 3f;//the time between each wave

    public float TimebetweenEnemies;//time between enemies within a wave

    private int waveNumber = 0;//start wave number

    private void Update()
    {
        if (countdown <= 0f)//when start countdown hits 0
        {
            StartCoroutine(SpawnWave());//starts the SpawnWave Coroutine
            countdown = TimebetweenWaves; //countdown is changed into TimeBetweenEnemies
        }
        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveNumber++;
        TimebetweenWaves++;//increases time between waves so enemies don't pile up

        for (int i = 0; i < waveNumber; i++)//a wave
        {
            spawnEnemy();
            yield return new WaitForSeconds(TimebetweenEnemies);//time to wait betwen enemies
        }

    }
    void spawnEnemy()//spawns the enemy
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
