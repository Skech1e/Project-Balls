using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReporting : MonoBehaviour
{
    public static Basket[] basketCount;
    public Basket[] basketCountIns;

    public static int goalCount;

    public delegate void OnGoalReport();
    public static event OnGoalReport LevelComplete;
    public static event OnGoalReport LevelReset;

    private void OnEnable()
    {
        Scored.GoalScored += GoalTracker;
        Scored.GoalScored += UpdateScores;

        UIController.OnUIEvent += ResetLevel;
    }
    private void OnDisable()
    {
        Scored.GoalScored -= GoalTracker;
        Scored.GoalScored -= UpdateScores;

        UIController.OnUIEvent -= ResetLevel;
    }


    // Start is called before the first frame update
    void Start()
    {
        basketCount = FindObjectsOfType<Basket>(false);
        
        goalCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        basketCountIns = basketCount;
    }

    void ResetLevel()
    {
        goalCount = 0;
        foreach (Basket basket in basketCount)
            basket.gameObject.SetActive(true);
        Ball.resetBall = true;
        LevelReset.Invoke();
        Time.timeScale = 1;
    }



    void GoalTracker()
    {
        goalCount++;
        if (goalCount == basketCount.Length)
            LevelComplete.Invoke();
    }

    void UpdateScores()
    {

    }

    void RecordScoresToFile()
    {

    }
}
