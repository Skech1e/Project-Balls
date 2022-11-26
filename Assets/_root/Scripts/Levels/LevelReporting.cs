using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class LevelReporting : MonoBehaviour
{
    static Basket[] basketCount;
    [SerializeField] Basket[] basketCountIns;

    enum BallCountEnum: int 
    {
        Three = 3, Six = 6, Nine = 9
    }

    [SerializeField] BallCountEnum _BallCount;

    public int ballCount;
    public static int goalCount;

    public delegate void OnGoalReport();
    public static event OnGoalReport LevelComplete;
    public static event OnGoalReport LevelReset;
    public static event OnGoalReport LevelFailed;

    private void OnEnable()
    {
        Scored.GoalScored += GoalTracker;
        Scored.GoalScored += UpdateScores;

        UIController.OnUIEvent += ResetLevel;
        Ball.BallEvent += BallLivesTracker;
    }
    private void OnDisable()
    {
        Scored.GoalScored -= GoalTracker;
        Scored.GoalScored -= UpdateScores;

        UIController.OnUIEvent -= ResetLevel;
        Ball.BallEvent -= BallLivesTracker;
    }


    // Start is called before the first frame update
    void Start()
    {
        basketCount = FindObjectsOfType<Basket>(false);
        ballCount = (int)_BallCount;
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

    void BallLivesTracker()
    {
        ballCount--;
        if (ballCount == 0)
            LevelFailed.Invoke();
    }

    void UpdateScores()
    {

    }

    void RecordScoresToFile()
    {

    }

}
