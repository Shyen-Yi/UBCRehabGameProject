using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroidSpawner : MonoBehaviour
{
    public GameObject meteoroidPrefab;
    public float spawnInterval = 2.0f;
    public float spawnHeight = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Start spawning meteoroids
        StartCoroutine(SpawnMeteoroids());
    }

    IEnumerator SpawnMeteoroids()
    {
        while (true)
        {
            // Instantiate a meteoroid at a random x-position within the screen bounds
            float spawnX = Random.Range(-6.0f, 6.0f);
            Vector3 spawnPosition = new Vector3(spawnX, spawnHeight, 0.0f);
            Instantiate(meteoroidPrefab, spawnPosition, Quaternion.identity);

            // Wait for the specified spawn interval
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}