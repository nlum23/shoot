using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] animalPrefabs;
	private float spawnRangeX = 45;
	private float spawnPosZ = 220;
    private float startDelay = 2;
    private float spawnInterval = 1.9f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
        void SpawnRandomAnimal()
        {
            float xSpawn = Random.Range(1, 100) > 50 ? -spawnRangeX : spawnRangeX;
            Vector3 spawnPos = new Vector3(xSpawn, 40f, Random.Range(190, 230));
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            GameObject bird = Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
            if (xSpawn == spawnRangeX)
            {
                bird.transform.eulerAngles = new Vector3(0.0f, 270.0f, 0.0f);
            }
    }
    

}
