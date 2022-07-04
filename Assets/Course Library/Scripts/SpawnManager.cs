using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private int xLocation = 20, zLocation = 20;
    private float startDelay = 2, spawnInterval = 1.5f;
    public static int animalIndex;
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
        animalIndex = Random.Range(0, animalPrefab.Length);
        UnityEngine.Vector3 spawnPosition = new UnityEngine.Vector3(Random.Range(-xLocation, xLocation), 0, zLocation);
        Instantiate(animalPrefab[animalIndex], spawnPosition, animalPrefab[animalIndex].transform.rotation);

    }
}
