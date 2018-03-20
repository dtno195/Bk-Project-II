using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBot : MonoBehaviour
{

    public GameObject[] spawnPoints;
    private int indexSpawnPoint;
    public GameObject car;
    public float minSpawTime = 1f;
    public float maxSpawnTime = 2f;
    private float lastSpawnTime = 0;
    private float spawnTime = 0;

	// Use this for initialization
	void Start () {
     
		UpdateSpawnTime();
	}

    void UpdateSpawnTime()
    {
        lastSpawnTime = Time.time;
        spawnTime = Random.Range(minSpawTime, maxSpawnTime);
    }

    void Spawn()
    {
        var indexSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(car, spawnPoints[indexSpawnPoint].transform.position, Quaternion.identity);

        UpdateSpawnTime();
    }
	
	// Update is called once per frame
	void Update () {
	    if (Time.time >= lastSpawnTime + spawnTime)
	    {
	        Spawn();
	    }
	}
}
