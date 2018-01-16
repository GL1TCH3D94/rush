using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject enemy;
	public Vector3 spawnValues;
	public int enemyCount;
    private int round = 1;

	public GameObject[] spawnPoints;

	void Start ()
	{
		
	}

	void Update () {

        round += 2;
		enemyCount = GameObject.FindGameObjectsWithTag ("EnemyObject").Length;
        Debug.Log(enemyCount);
		if (enemyCount == 0) {

			for (int i = 0; i < round; i++)
			{
				Vector3 spawnPosition = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (enemy, spawnPosition, spawnRotation);
			}

		}

	}

}