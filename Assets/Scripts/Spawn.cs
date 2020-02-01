using System;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnPoint;

    public GameObject prefab;

    [Range(1, 1000)]
    public int number = 1000;

    public int range = 1;

    private System.Random rand;


    // Start is called before the first frame update
    void Start()
    {
        var originalPos = spawnPoint.transform.position;
        for (int i = 0; i < number; i++)
        {
            rand = new System.Random();
            var randpos = originalPos;
            randpos.x = (float)rand.NextDouble();
            randpos.z = (float)rand.NextDouble();
            Instantiate(prefab, randpos, Quaternion.identity);
        }
    }
}