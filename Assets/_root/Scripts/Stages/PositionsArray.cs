using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionsArray : MonoBehaviour
{    
    public List<Transform> positionArray = new();
    public Transform[,] target = new Transform[3,5];
    bool test;

    public Transform GetPosition(int id) => transform.GetChild(id);

    private void Awake()
    {
        positionArray.Capacity = 15;

        for (int j = 0; j < positionArray.Capacity; j++)
        {
            positionArray.Add(transform.GetChild(j));
        }

        /*var k = 0;
        for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                target[i, j] = transform.GetChild(j+k);
            }
            k += 5;
        }*/   
    }

}
