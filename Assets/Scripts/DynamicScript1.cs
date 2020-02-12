using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicScript1 : MonoBehaviour
{
    public GameObject pickup;
    public Vector3 center;
    public Vector3 size;


    // When the game starts, have 6 objects 
    void Start()
    {
        switch (GameObject.FindGameObjectsWithTag("Pick Up 1").Length)
        {
            case 1:

                {
                    for (int i = 1; i <= 6; i++)
                    {
                        RandomSpawnObjects();
                    }
                }
                break;
        }
    }

    //randomly spawn these objects within a given space
    private void RandomSpawnObjects()
    {
        Vector3 position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(pickup, position, Quaternion.identity);
    }
}