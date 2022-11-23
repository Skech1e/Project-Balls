using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageHandler : MonoBehaviour
{    
    public bool test;
    public Scored[] basketCount;
    [SerializeField] int goalCount;
    [SerializeField] int currentLevel;

   


    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        
    }


    void LevelChange()
    {

    }

    public void ChangeLevel()
    {

        goalCount = 0;
    }
 
    void ResetGoalCount()
    {
        goalCount = 0;
    }

    void GoalTracker()
    {
    }


}