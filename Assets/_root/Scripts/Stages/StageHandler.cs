using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;

public class StageHandler : MonoBehaviour
{
    [SerializeField] List<GameObject> Levels = new();
    [SerializeField] PositionsArray pa;

    public bool loadNext;
    public int currentLevel;

    public bool test;
    public int count;


    private void Awake()
    {       
        for(int i = 0; i < Levels.Capacity; i++)
        {
            Levels[i].SetActive(false);
        }

        LevelInit();
    }

    private void Update()
    {
        if (loadNext == true)
            LevelChange();

        //basket[0].transform.parent.position = Vector3.MoveTowards(basket[0].transform.parent.position, level[currentLevel].position, Time.deltaTime*5);
    }

    void LevelInit()
    {
            
    }

    void LevelChange()
    {
        currentLevel++;
        loadNext = false;
    }

 

    // Start is called before the first frame update
    void Start()
    {

    }


}