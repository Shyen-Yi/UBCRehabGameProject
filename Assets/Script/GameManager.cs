using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject meteoroidPrefab;
    public float maxX;
    public float maxY;
    public Transform spawnPoint;
    public float spawnRate = 2.0f; // Adjust the spawn rate as needed
    private bool gameStarted = false;

    void Start()
    {
        // Start spawning meteoroids after a delay
        StartCoroutine(StartSpawning());
    }

    void Update()
    {
        // You can add game-related logic here if needed
    }

    private IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(2.0f); // Delay before starting spawning

        gameStarted = true;

        while (gameStarted)
        {
            SpawnMeteoroid();
            yield return new WaitForSeconds(spawnRate);
        }
    }

    private void SpawnMeteoroid()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxX, maxX);
        spawnPos.y = Random.Range(-maxY, maxY);

        Instantiate(meteoroidPrefab, spawnPos, Quaternion.identity);
    }

    // You can use this method to stop spawning meteoroids
    public void StopSpawning()
    {
        gameStarted = false;
    }
}