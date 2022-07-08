using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float rate;
    public GameObject[] ennemies;
    public int waves = 1;

    void Start()
    {
        InvokeRepeating("SpawnEnnemy", rate, rate);
    }

    void SpawnEnnemy()
    {
        for (int i = 0; i<waves;i++)
        Instantiate(ennemies[Random.Range(0,ennemies.Length)],new Vector3(Random.Range(-9,9),7,0),Quaternion.identity); 
    }
}
