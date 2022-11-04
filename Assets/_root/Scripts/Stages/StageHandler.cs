using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageHandler : MonoBehaviour
{
    [SerializeField] List<GameObject> Levels = new();

    public bool loadNext;
    public int currentLevel;

    public bool test;
    public int count;
       
    
    private void Awake()
    {
        currentLevel = 0;
    }   

    private void Update()
    {
        
    }


    void LevelChange()
    {
        currentLevel++;
        loadNext = false;
    }

    public void ChangeLevel()
    {
        print(Levels[currentLevel].name);
        Levels[currentLevel].SetActive(false);
        currentLevel++;
        if (currentLevel < 20)
            Levels[currentLevel].SetActive(true);
    }
 

    // Start is called before the first frame update
    void Start()
    {
        Levels[currentLevel].SetActive(true);
    }


}