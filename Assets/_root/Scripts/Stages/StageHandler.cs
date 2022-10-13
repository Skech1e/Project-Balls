using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageHandler : MonoBehaviour
{

    [SerializeField] List<Transform> level = new();
    [SerializeField] List<Scored> basket = new();
    [SerializeField] PositionsArray pa;

    [Header("Debug")]
    [SerializeField] ArrayViewer av;
    public bool test;
    float offset = 0.8f;
    public int count;
    enum LevelType { still, moving }

    LevelType leveltype = new LevelType();

    [SerializeField] Stack <int> istack, jstack = new();

    private void Awake()
    {
        istack.Count = 4;
        jstack.Count = 4;
        level.Capacity = 10;
        //level[0] = pa.positionArray[0];

    }

    private void OnValidate()
    {
        count = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (av.columns[i].rows[j] == true)
                {
                    istack.Push(i);
                    jstack.Push(j);
                    count++;
                    if(count > 3)
                    {

                    }
                    basket[count].transform.parent.position = pa.target[i, j].position;
                    //basket.transform.parent.position += Vector3.back * offset;
                }
            }
        }


        switch (leveltype)
        {
            case LevelType.still:

                break;
            case LevelType.moving:
                break;
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
