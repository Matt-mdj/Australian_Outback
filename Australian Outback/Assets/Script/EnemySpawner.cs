using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    private int xPos;
    private int zPos;
    private int enemyCount;

    public int numberOfEnemies;

    public int timeToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < numberOfEnemies)
        {
            xPos = Random.Range(75, -76);
            zPos = Random.Range(-5, 130);

            Instantiate(enemy, new Vector3(xPos, 0, zPos), Quaternion.identity);

            yield return new WaitForSeconds(timeToSpawn);

            enemyCount += 1;
        }
    }
}