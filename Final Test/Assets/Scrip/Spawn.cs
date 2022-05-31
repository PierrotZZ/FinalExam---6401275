using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject SpawnAnyThing;

    void Start()
    {
        float randomposy = Random.Range(-8.16f, 1.59f);
        float randomposx = Random.Range(-10f, 7.65f);
        float randomposz = 0;
        Vector3 randompos = new Vector3(randomposx, randomposy, randomposz);
        Instantiate(SpawnAnyThing, randompos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    
}
