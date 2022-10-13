using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionsArray : MonoBehaviour
{    
    public List<Transform> positionArray = new();
    public Transform[,] target = new Transform[3,5];
    bool test;

    private void OnValidate()
    {
        positionArray.Capacity = 15;

        /*for (int i = 0; i < 15; i++)
        {
            positionArray[i] = transform.GetChild(i);
        }*/
        var k = 0;
        for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                target[i, j] = transform.GetChild(j+k);
            }
            k += 5;
        }   
    }
}
