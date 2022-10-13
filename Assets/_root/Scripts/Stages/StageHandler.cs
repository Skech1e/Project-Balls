using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageHandler : MonoBehaviour
{

    [SerializeField] List<Transform> level = new();
    [SerializeField] Scored basket;
    [SerializeField] PositionsArray pa;

    [Header("Debug")]
    [SerializeField] ArrayViewer av;
    public bool test;
    float offset = 0.8f;
    
    private void Awake()
    {
        level.Capacity = 10;
        //level[0] = pa.positionArray[0];

    }

    private void OnValidate()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (av.columns[i].rows[j] == true)
                {
                    basket.transform.parent.position = pa.target[i, j].position;
                    //basket.transform.parent.position += Vector3.back * offset;
                }
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
