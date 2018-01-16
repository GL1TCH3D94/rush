using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WaveSpawn : MonoBehaviour {

    public GameObject[] spawnPoint = new GameObject[5];
    public GameObject spawnObject;
    public int waveDelay = 10;
    public int totalEnemies = 0;
    public int round = 1;
    public int numberToSpawn = 1;


    // Update is called once per frame
    void Update()
    {
        Debug.Log(totalEnemies);

        totalEnemies = GameObject.FindGameObjectsWithTag("EnemyObject").Length;

        Debug.Log(totalEnemies + " After");
        if (totalEnemies <= 0)
        {
            StartCoroutine(Spawn());
        }
        
    }
    private IEnumerator Spawn()
    {
        Debug.Log("routine");
        numberToSpawn = round + 2;
        round++;

        
        for(int i = 0; i < numberToSpawn; i++)
        {
            Transform spawn = spawnPoint[i].transform;

            Instantiate(spawnObject, spawn.position, spawn.rotation);
            Debug.Log("Spawned");
            
            
        }
        yield return new WaitForSeconds(waveDelay);


    }
}
