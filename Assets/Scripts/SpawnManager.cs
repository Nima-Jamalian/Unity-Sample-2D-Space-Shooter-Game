using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float enemySpawnRate = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            Vector3 enemySpawnRange = new Vector3(
                Random.Range(-GameManager.worldSizeWidth,GameManager.worldSizeWidth), 
                GameManager.worldSizeHeight,
                0);
            Instantiate(enemyPrefab, enemySpawnRange, Quaternion.identity);
            yield return new WaitForSeconds(enemySpawnRate);
        }
    }

}
