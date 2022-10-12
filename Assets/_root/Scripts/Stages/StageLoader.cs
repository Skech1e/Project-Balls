using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLoader : MonoBehaviour
{
    [SerializeField] Transform positions;
    [SerializeField] Transform[,] positionArray;
    int a = 3, b = 5;
    private void Awake()
    {
        positionArray = new Transform[a, b];

        for(int i = 0; i < a; i++)
        {
            for(int j = 0; j < b; j++)
            {
                positionArray[i, j] = positions.transform.GetChild(i).transform.GetChild(j);
                print(positionArray[i,j].name);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
