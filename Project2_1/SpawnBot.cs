using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBot : MonoBehaviour
{

    public GameObject[] spawnPoints;// so luong điểm tạo bot
    private int indexSpawnPoint; // chi muc cua diem khoi tao
    public GameObject zombie; // doi tuong can khoi tao
    public float minSpawTime = 0.2f; // thoi gian tao thap nhat
    public float maxSpawnTime = 1; // thoi gian tao dai nhat
    private float lastSpawnTime = 0; // thoi gian tao cuoi cung
    private float spawnTime = 1; //thoi gian sinh

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

        Instantiate(zombie, spawnPoints[indexSpawnPoint].transform.position, Quaternion.identity);

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
