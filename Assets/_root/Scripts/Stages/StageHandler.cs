using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageHandler : MonoBehaviour
{    
    public bool test;
    public Scored[] basketCount;
    [SerializeField] int goalCount;

    public delegate void LevelFinish();
    public static event LevelFinish OnLevelFinish;


    private void OnEnable()
    {
        Scored.GoalScored += GoalTracker;
    }

    private void OnDisable()
    {
        Scored.GoalScored -= GoalTracker;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        basketCount = FindObjectsOfType<Scored>(false);
    }

    private void Update()
    {
        
    }


    void LevelChange()
    {

    }

    public void ChangeLevel()
    {

    }
 
    void ResetGoalCount()
    {
        goalCount = 0;
    }

    void GoalTracker()
    {
        goalCount++;
        if (goalCount == basketCount.Length)
            OnLevelFinish.Invoke();
    }


}