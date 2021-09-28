using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 10;
    float countTarget = 100;
    float rateCounter = 0;

    public GameObject spawnObj;

    private void Start()
    {
        rateCounter = Random.Range(0, countTarget-spawnRate);
    }

    void Update()
    {
        if (rateCounter > countTarget)
        {
            Instantiate(spawnObj, transform.position, transform.rotation);
            rateCounter = 0;
        } else
        {
            rateCounter += spawnRate + Random.Range(-(spawnRate * 2), spawnRate * 2);
        }
    }
}
