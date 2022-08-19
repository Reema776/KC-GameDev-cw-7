using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enmy : MonoBehaviour
{
    public GameObject Obstacle;
    public float spawnRate;
    public Transform minPos;
    public Transform midPos;
    public Transform maxPos;
    

    void Start()
    {
        InvokeRepeating("Spawning", spawnRate, spawnRate);
    }


    void Spawning()
    {

        //Instantiate(Obstacle, maxPos);

        int choice = Random.Range(1, 4);
        if (choice == 1)
        {
            Instantiate(Obstacle, maxPos);
        }
        else if (choice == 2)
        {
            Instantiate(Obstacle, midPos);
        }
        else
        {
            Instantiate(Obstacle, minPos);
        }        


    }
}
